namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Carnage.Core.Rules.Data.Attributes;
    using Microsoft.SqlServer.Dac;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.KeywordsUppercaseRuleId, Constants.ResourceBaseName, RuleName, ProblemDescription, Category = Constants.General, RuleScope = SqlRuleScope.Element)]
    public sealed class KeywordsUppercaseRule : CarnageSqlCodeAnalysisRule
    {
        private const string ProblemDescription = "KeywordsMustBeInUppercaseDescription";
        private const string RuleName = "KeywordsMustBeInUppercaseName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>();

            foreach (var token in fragment.ScriptTokenStream)
            {
                if (token.IsKeyword() && token.Text.Any(char.IsLower)) 
                {
                    var description = string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription);
                    var problem = new SqlRuleProblem(description, modelElement)
                    {
                        Severity = SqlRuleProblemSeverity.Error
                    };

                    problem.SetSourceInformation(new SourceInformation(problem.SourceName, token.Line, token.Column));
                    problems.Add(problem);
                }
            }

            return problems;
        }
    }
}
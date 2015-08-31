namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.ProhibitedTypesRuleId, Constants.ResourceBaseName, RuleName, ProblemDescription, Category = Constants.Design, RuleScope = SqlRuleScope.Element)]
    public sealed class InvalidTypesRule : CarnageSqlCodeAnalysisRule
    {
        private const string ProblemDescription = "InvalidTypesProblemDescription";
        private const string RuleName = "InvalidTypesRuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>();
            var visitor = new InvalidTypesVisitor();

            fragment.Accept(visitor);

            foreach (var item in visitor.ColumnDefinitions)
            {
                var description = string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription);
                var problem = new SqlRuleProblem(description, modelElement, item)
                {
                    Severity = SqlRuleProblemSeverity.Warning
                };

                problems.Add(problem);                
            }

            foreach (var item in visitor.ProcedureParameters)
            {
                var description = string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription);
                var problem = new SqlRuleProblem(description, modelElement, item)
                {
                    Severity = SqlRuleProblemSeverity.Warning
                };

                problems.Add(problem);
            }

            return problems;
        }
    }
}
namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.TableAliasRuleId, Constants.ResourceBaseName, RuleName, ProblemDescription, Category = Constants.General, RuleScope = SqlRuleScope.Element)]
    public sealed class TableAliasRule : CarnageSqlCodeAnalysisRule
    {
        private const string ProblemDescription = "TableAliasProblemDescription";
        private const string RuleName = "TableAliasRuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>();
            var visitor = new TableAliasVisitor();

            fragment.Accept(visitor);

            foreach (var namedTableReference in visitor.NamedTableReferences)
            {
                var description = string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription);
                var problem = new SqlRuleProblem(description, modelElement, namedTableReference)
                {
                    Severity = SqlRuleProblemSeverity.Warning
                };

                problems.Add(problem);                    
            }

            return problems;
        }
    }
}
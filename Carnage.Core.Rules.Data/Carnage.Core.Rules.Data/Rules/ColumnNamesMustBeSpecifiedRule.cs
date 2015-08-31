namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.ColumnNamesMustBeSpecifiedRuleId, Constants.ResourceBaseName, ColumnNameMustBeSpecifiedRuleName, ColumnNameMustBeSpecifiedProblemDescription, Category = Constants.General, RuleScope = SqlRuleScope.Element)]
    public sealed class ColumnNamesMustBeSpecifiedRule : CarnageSqlCodeAnalysisRule
    {
        private const string ColumnNameMustBeSpecifiedProblemDescription = "ColumnNameMustBeSpecified_ProblemDescription";
        private const string ColumnNameMustBeSpecifiedRuleName = "ColumnNameMustBeSpecified_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ColumnNameVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsError(ruleDescriptor, elementName, modelElement, visitor.InvalidInsertStatementsWithoutColumnNames);
        }
    }
}

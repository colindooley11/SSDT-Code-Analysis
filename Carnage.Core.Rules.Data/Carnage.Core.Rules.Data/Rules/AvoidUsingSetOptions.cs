namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.AvoidUsingSetOptionsRuleId,
    Constants.ResourceBaseName,
    AvoidUsingSetOptionsRuleName,
   AvoidUsingSetOptionsProblemDescription,
    Category = Constants.General,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class AvoidUsingSetOptions : CarnageSqlCodeAnalysisRule
    {
        private const string AvoidUsingSetOptionsProblemDescription = "AvoidUsingSetOptions_ProblemDescription";
        private const string AvoidUsingSetOptionsRuleName = "AvoidUsingSetOptions_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new SetOptionsVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.InvalidSetStatements);
        }
    }
}

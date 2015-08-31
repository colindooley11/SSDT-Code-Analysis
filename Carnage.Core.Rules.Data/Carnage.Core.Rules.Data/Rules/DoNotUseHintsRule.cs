namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.DoNotUseHintsRuleId,
    Constants.ResourceBaseName,
    DoNotUseHintsRuleName,
    DoNotUseHintsProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DoNotUseHintsRule : CarnageSqlCodeAnalysisRule
    {
        private const string DoNotUseHintsProblemDescription = "DoNotUseHints_ProblemDescription";
        private const string DoNotUseHintsRuleName = "DoNotUseHints_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new HintsVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsError(ruleDescriptor, elementName, modelElement, visitor.Hints);
        }
    }
}

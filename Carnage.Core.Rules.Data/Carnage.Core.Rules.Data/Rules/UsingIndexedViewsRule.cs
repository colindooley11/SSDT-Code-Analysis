namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.UsingIndexedViewsRuleId,
    Constants.ResourceBaseName,
    UsingIndexedViewsRuleName,
    UsingIndexedViewsProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class UsingIndexedViewsRule : CarnageSqlCodeAnalysisRule
    {
        private const string UsingIndexedViewsProblemDescription = "UsingIndexedViews_ProblemDescription";
        private const string UsingIndexedViewsRuleName = "UsingIndexedViews_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new UsingIndexedViewsVisitor();
            fragment.Accept(visitor);
            var problems = (List<SqlRuleProblem>)this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.WithBindings);
            problems.AddRange(this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.IndexedViews));
            return problems;
        }
    }
}

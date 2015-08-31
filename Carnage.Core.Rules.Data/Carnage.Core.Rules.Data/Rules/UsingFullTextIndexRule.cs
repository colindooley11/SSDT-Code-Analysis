namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.FullTextIndexRuleId,
    Constants.ResourceBaseName,
    UsingFullTextIndexRuleName,
    UsingFullTextIndexProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class UsingFullTextIndexRule : CarnageSqlCodeAnalysisRule
    {
        private const string UsingFullTextIndexProblemDescription = "UsingFullTextIndex_ProblemDescription";
        private const string UsingFullTextIndexRuleName = "UsingFullTextIndex_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new UsingFullTextIndexVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.FullTextIndexes); 
         }
    }
}

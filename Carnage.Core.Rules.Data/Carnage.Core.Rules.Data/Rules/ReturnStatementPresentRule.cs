namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.ReturnStatementPresentRuleId,
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : CarnageSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CreateProcedureReturnVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}

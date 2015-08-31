namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.AvoidUsingGlobalVariableForIdentityRuleId,
    Constants.ResourceBaseName,
    AvoidUsingGlobalVariableForIdentityRuleName,
   AvoidUsingGlobalVariableForIdentityProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class AvoidUsingGlobalVariableForIdentityRule : CarnageSqlCodeAnalysisRule
    {
        private const string AvoidUsingGlobalVariableForIdentityProblemDescription = "AvoidUsingGlobalVariableForIdentity_ProblemDescription";
        private const string AvoidUsingGlobalVariableForIdentityRuleName = "AvoidUsingGlobalVariableForIdentity_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new AvoidUsingGlobalVariableForIdentityVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsError(ruleDescriptor, elementName, modelElement, visitor.InvalidVariables);
        }
    }
}

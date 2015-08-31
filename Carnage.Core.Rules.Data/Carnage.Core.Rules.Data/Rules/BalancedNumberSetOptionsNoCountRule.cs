namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.BalancedNumberOfSetOptionsNoCountRuleId,
    Constants.ResourceBaseName,
    OddNumberOfSetOptionsNoCountRuleName,
   OddNumberOfSetOptionsNoCountProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class BalancedNumberSetOptionsNoCountRule : CarnageSqlCodeAnalysisRule
    {
        private const string OddNumberOfSetOptionsNoCountProblemDescription = "BalancedNumberSetOptionsNoCount_ProblemDescription";
        private const string OddNumberOfSetOptionsNoCountRuleName = "BalancedNumberSetOptionsNoCount_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CreateProcedureVisitor();
            fragment.Accept(visitor);
            var invalidSetStatements = new List<PredicateSetStatement>();

            if (visitor.ShouldRunBalancedCheck)
            {
                if (visitor.SetStatements.Count > 0)
                {
                    var remainder = visitor.SetStatements.Count % 2;
                    var setStatementsLessRemainder = visitor.SetStatements.Count - remainder;

                    if (remainder > 0)
                    {
                        invalidSetStatements.Add(visitor.SetStatements[visitor.SetStatements.Count - 1]);
                    }

                    for (var i = 0; i < setStatementsLessRemainder; i += 2)
                    {
                        if (!(visitor.SetStatements[i].IsOn && (!visitor.SetStatements[i + 1].IsOn)))
                        {
                            invalidSetStatements.Add(visitor.SetStatements[i]);
                            invalidSetStatements.Add(visitor.SetStatements[i + 1]);
                        }
                    }
                }
                else
                {
                    return this.CreateProblemsAsError(ruleDescriptor, elementName, modelElement, new List<TSqlFragment> { fragment });
                }
            }
            
            return this.CreateProblemsAsError(ruleDescriptor, elementName, modelElement, invalidSetStatements);
        }
    }
}

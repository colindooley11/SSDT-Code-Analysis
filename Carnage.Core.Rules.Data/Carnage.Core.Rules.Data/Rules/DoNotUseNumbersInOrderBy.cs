namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.DoNotUseNumbersInOrderByRuleId,
    Constants.ResourceBaseName,
    DoNotUseNumbersInOrderByRuleName,
    DoNotUseNumbersInOrderByProblemDescription,
    Category = Constants.General,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DoNotUseNumbersInOrderBy : CarnageSqlCodeAnalysisRule
    {
        private const string DoNotUseNumbersInOrderByProblemDescription = "DoNotUseNumbersInOrderBy_ProblemDescription";
        private const string DoNotUseNumbersInOrderByRuleName = "DoNotUseNumbersInOrderBy_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>(); 
            var visitor = new OrderByVisitor();
            fragment.Accept(visitor);

            foreach (var orderByClause in visitor.InvalidOrderByClauseWithNumber)
            {
                var problem = new SqlRuleProblem(string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription, elementName), modelElement, orderByClause);
                problem.Severity = SqlRuleProblemSeverity.Error;
                problems.Add(problem);
            }

            return problems; 
        }
    }
}

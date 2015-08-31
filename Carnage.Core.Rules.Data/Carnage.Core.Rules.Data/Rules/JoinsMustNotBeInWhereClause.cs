namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Asos.Core.Rules.Data.Attributes;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.JoinsMustNotBeInWhereClauseRuleId,
        Constants.ResourceBaseName,
        JoinsMustNotBeInWhereClauseRuleName,
        JoinsMustNotBeInWhereClauseProblemDescription,
        Category = Constants.General,
        RuleScope = SqlRuleScope.Element)]
    internal sealed class JoinsMustNotBeInWhereClause : AsosSqlCodeAnalysisRule
    {
        private const string JoinsMustNotBeInWhereClauseProblemDescription = "JoinsMustNotBeInWhereClause_ProblemDescription";
        private const string JoinsMustNotBeInWhereClauseRuleName = "JoinsMustNotBeInWhereClause_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>();
            var visitor = new WhereVisitor();
            fragment.Accept(visitor);

            if (visitor.IsWhereClauseInvalid) 
            {
                var problem = new SqlRuleProblem(string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription, elementName), modelElement, visitor.InvalidWhereClause);
                problem.Severity = SqlRuleProblemSeverity.Error;
                problems.Add(problem);
            }

            foreach (var invalidBooleanExpression in visitor.InvalidBooleanExpresion)
            {
                var problem = new SqlRuleProblem(string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription, elementName), modelElement, invalidBooleanExpression);
                problem.Severity = SqlRuleProblemSeverity.Error;
                problems.Add(problem);
            }

            return problems;
        }
    }
}
namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.DdlRuleId, Constants.ResourceBaseName, RuleName, ProblemDescription, Category = Constants.Design, RuleScope = SqlRuleScope.Element)]
    public sealed class DdlRule : CarnageSqlCodeAnalysisRule
    {
        private const string ProblemDescription = "UseOfDDLProblemDescription";
        private const string RuleName = "UseOfDDLRuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>();
            var visitor = new StoredProcedureVisitor();

            fragment.Accept(visitor);

            visitor.AlterTableStatements
                .ToList()
                .ForEach(x => problems.Add(AddProblem(modelElement, ruleDescriptor, x)));

            visitor.CreateTableStatements
                .ToList()
                .ForEach(x => problems.Add(AddProblem(modelElement, ruleDescriptor, x)));

            visitor.DropTableStatements
                .ToList()
                .ForEach(x => problems.Add(AddProblem(modelElement, ruleDescriptor, x)));

            return problems;
        }

        private static SqlRuleProblem AddProblem(TSqlObject modelElement, RuleDescriptor ruleDescriptor, TSqlFragment fragment)
        {
            var description = string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription);
            var problem = new SqlRuleProblem(description, modelElement, fragment)
            {
                Severity = SqlRuleProblemSeverity.Warning
            };

            return problem;
        }
    }
}
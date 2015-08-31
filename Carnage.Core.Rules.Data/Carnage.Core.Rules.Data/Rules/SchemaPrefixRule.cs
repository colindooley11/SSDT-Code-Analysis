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

    [LocalizedExportCodeAnalysisRule(RuleIdentities.SchemaPrefixRuleId, Constants.ResourceBaseName, RuleName, ProblemDescription, Category = Constants.General, RuleScope = SqlRuleScope.Element)]
    public class SchemaPrefixRule : CarnageSqlCodeAnalysisRule
    {
        private const string ProblemDescription = "SchemaPrefixProblemDescription";
        private const string RuleName = "SchemaPrefixRuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>();
            var visitor = new SchemaVisitor();

            fragment.Accept(visitor);

            visitor.NamedTableReferences
                .ToList()
                .ForEach(x => problems.Add(AddProblem(modelElement, ruleDescriptor, x)));

            visitor.FunctionCalls
                .ToList()
                .ForEach(x => problems.Add(AddProblem(modelElement, ruleDescriptor, x)));

            visitor.ProcedureReferences
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
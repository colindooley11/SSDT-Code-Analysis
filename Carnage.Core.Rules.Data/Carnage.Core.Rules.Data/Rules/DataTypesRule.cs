namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.DataTypesLowercaseRuleId, Constants.ResourceBaseName, RuleName, ProblemDescription, Category = Constants.General, RuleScope = SqlRuleScope.Element)]
    public sealed class DataTypesRule : CarnageSqlCodeAnalysisRule
    {
        private const string ProblemDescription = "DataTypesMustBeInLowercaseDescription";
        private const string RuleName = "DataTypesMustBeInLowercaseName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var problems = new List<SqlRuleProblem>();
            var visitor = new DataTypesVisitor();

            fragment.Accept(visitor);

            foreach (var columnDef in visitor.ColumnDefinitions)
            {
                var description = string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription);
                var problem = new SqlRuleProblem(description, modelElement)
                {
                    Severity = SqlRuleProblemSeverity.Error
                };

                problem.SetSourceInformation(new SourceInformation(problem.SourceName, columnDef.StartLine, columnDef.StartColumn));
                problems.Add(problem);
            }


            foreach (var parameter in visitor.ProcedureParameters)
            {
                var description = string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription);
                var problem = new SqlRuleProblem(description, modelElement)
                {
                    Severity = SqlRuleProblemSeverity.Error
                };

                problem.SetSourceInformation(new SourceInformation(problem.SourceName, parameter.StartLine, parameter.StartColumn));
                problems.Add(problem);
            }

            return problems;
        }
    }
}
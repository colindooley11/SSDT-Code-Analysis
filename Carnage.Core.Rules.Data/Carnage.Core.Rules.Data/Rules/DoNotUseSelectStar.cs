namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.DoNotUseSelectAllRuleId,
    Constants.ResourceBaseName,
    SelectStarExpressionRuleName,
    SelectStarExpressionProblemDescription,
    Category = Constants.General,
    RuleScope = SqlRuleScope.Element)]
    public sealed class DoNotUseSelectAllRule : SqlCodeAnalysisRule
    {
        private const string SelectStarExpressionProblemDescription = "SelectStarExpression_ProblemDescription";
        private const string SelectStarExpressionRuleName = "SelectStarExpression_RuleName";

        public DoNotUseSelectAllRule()
        {
            this.SupportedElementTypes = new[]
           {
              // Note: can use the ModelSchema definitions, or access the TypeClass for any of these types
              ModelSchema.ExtendedProcedure,
              ModelSchema.Procedure,
              ModelSchema.TableValuedFunction,
              ModelSchema.ScalarFunction,
         
              ModelSchema.DatabaseDdlTrigger,
              ModelSchema.DmlTrigger,
              ModelSchema.ServerDdlTrigger
           };
        }

        public override IList<SqlRuleProblem> Analyze(SqlRuleExecutionContext ruleExecutionContext)
        {
            IList<SqlRuleProblem> problems = new List<SqlRuleProblem>();

            TSqlObject modelElement = ruleExecutionContext.ModelElement;

            string elementName = GetElementName(ruleExecutionContext, modelElement);

            TSqlFragment fragment = ruleExecutionContext.ScriptFragment;
            RuleDescriptor ruleDescriptor = ruleExecutionContext.RuleDescriptor;
            var visitor = new SelectStarVisitor();
            fragment.Accept(visitor);

            foreach (var selectStarExpression in visitor.SelectStarExpressions)
            {
                var problem = new SqlRuleProblem(string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription, elementName), modelElement, selectStarExpression);
                problem.Severity = SqlRuleProblemSeverity.Warning;
                problems.Add(problem);
            }
            
            return problems;
        }

        private static string GetElementName(SqlRuleExecutionContext ruleExecutionContext, TSqlObject modelElement)
        {
            // Get the element name using the built in DisplayServices. This provides a number of 
            // useful formatting options to
            // make a name user-readable
            var displayServices = ruleExecutionContext.SchemaModel.DisplayServices;
            string elementName = displayServices.GetElementName(modelElement, ElementNameStyle.EscapedFullyQualifiedName);
            return elementName;
        }
    }
}

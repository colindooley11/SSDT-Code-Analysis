namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.AvoidWaitForDelayRuleId,
    Constants.ResourceBaseName,
    AvoidWaitForDelayRuleName,
   AvoidWaitForDelayProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    public sealed class AvoidWaitForDelayRule : SqlCodeAnalysisRule
    { 
        private const string AvoidWaitForDelayProblemDescription = "AvoidWaitForDelay_ProblemDescription";
        private const string AvoidWaitForDelayRuleName = "AvoidWaitForDelay_RuleName";

        public AvoidWaitForDelayRule()
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

            if (IsInlineTableValuedFunction(modelElement))
            {
                return problems;
            }

            string elementName = GetElementName(ruleExecutionContext, modelElement);

            TSqlFragment fragment = ruleExecutionContext.ScriptFragment;
            RuleDescriptor ruleDescriptor = ruleExecutionContext.RuleDescriptor;
            WaitForDelayVisitor visitor = new WaitForDelayVisitor();

            fragment.Accept(visitor);

            IList<WaitForStatement> waitForDelayStatements = visitor.WaitForDelayStatements;

            foreach (WaitForStatement waitForStatement in waitForDelayStatements)
            {
                var problem = new SqlRuleProblem(string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription, elementName), modelElement, waitForStatement);
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
            string elementName = displayServices.GetElementName(
                modelElement, ElementNameStyle.EscapedFullyQualifiedName);
            return elementName;
        }

        private static bool IsInlineTableValuedFunction(TSqlObject modelElement)
        {
            return TableValuedFunction.TypeClass.Equals(modelElement.ObjectType)
                           && FunctionType.InlineTableValuedFunction ==
                modelElement.GetMetadata<FunctionType>(TableValuedFunction.FunctionType);
        }
    }
}
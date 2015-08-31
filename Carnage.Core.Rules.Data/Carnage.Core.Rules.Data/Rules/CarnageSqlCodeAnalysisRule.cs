namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using System.Globalization;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    public abstract class CarnageSqlCodeAnalysisRule : SqlCodeAnalysisRule
    {
        protected CarnageSqlCodeAnalysisRule()
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
                    ModelSchema.ServerDdlTrigger,
                    ModelSchema.View,
                    ModelSchema.Table,
                    ModelSchema.FullTextIndex
                };
        }

        public override IList<SqlRuleProblem> Analyze(SqlRuleExecutionContext ruleExecutionContext)
        {
            TSqlObject modelElement = ruleExecutionContext.ModelElement;
            string elementName = this.GetElementName(ruleExecutionContext, modelElement);
            TSqlFragment fragment = ruleExecutionContext.ScriptFragment;
            RuleDescriptor ruleDescriptor = ruleExecutionContext.RuleDescriptor;
            var problems = this.ElicitProblems(fragment, ruleDescriptor, elementName, modelElement);  
            return problems;
        }

        protected bool IsInlineTableValuedFunction(TSqlObject modelElement)
        {
            return TableValuedFunction.TypeClass.Equals(modelElement.ObjectType) && FunctionType.InlineTableValuedFunction == modelElement.GetMetadata<FunctionType>(TableValuedFunction.FunctionType);
        }

        protected string GetElementName(SqlRuleExecutionContext ruleExecutionContext, TSqlObject modelElement)
        {
            var displayServices = ruleExecutionContext.SchemaModel.DisplayServices;
            string elementName = displayServices.GetElementName(modelElement, ElementNameStyle.EscapedFullyQualifiedName);
            return elementName;
        }

        protected virtual IList<SqlRuleProblem> CreateProblemsAsError(RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement, IEnumerable<TSqlFragment> invalidSqlFragments)
        {
            return this.CreateProblems(ruleDescriptor, elementName, modelElement, invalidSqlFragments, SqlRuleProblemSeverity.Error);
        }

        protected virtual IList<SqlRuleProblem> CreateProblemsAsWarning(RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement, IEnumerable<TSqlFragment> invalidSqlFragments)
        {
            return this.CreateProblems(ruleDescriptor, elementName, modelElement, invalidSqlFragments, SqlRuleProblemSeverity.Warning);
        }

        protected virtual IList<SqlRuleProblem> CreateProblems(RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement, IEnumerable<TSqlFragment> invalidSqlFragments, SqlRuleProblemSeverity severity)
        {
            var problems = new List<SqlRuleProblem>();
            foreach (var invalidFragment in invalidSqlFragments)
            {
                var problem = new SqlRuleProblem(string.Format(CultureInfo.CurrentCulture, ruleDescriptor.DisplayDescription, elementName), modelElement, invalidFragment);
                problem.Severity = severity;
                problems.Add(problem);
            }

            return problems;
        }
         
        protected abstract IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement); 
    }  
}   
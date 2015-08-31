

 




    
namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.AvoidWaitForDelayRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DoNotUseSelectAllRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.KeywordsUppercaseRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.TableAliasRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.ColumnNamesMustBeSpecifiedRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DoNotUseNumbersInOrderByRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.SchemaPrefixRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.JoinsMustNotBeInWhereClauseRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.AvoidUsingSetOptionsRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.ProhibitedTypesRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.AvoidUsingGlobalVariableForIdentityRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.UsingIndexedViewsRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.FullTextIndexRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.UsingIndexedViewsId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.PrimaryKeyRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.CollationRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DynamicSqlRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.BalancedNumberOfSetOptionsNoCountRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.ReturnStatementPresentRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DoNotUseHintsRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DdlRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.HeaderRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DataTypesLowercaseRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Index_Type_Is_Not_Specified",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.ORDER_BY_clause_with_constants",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.SELECT_in_trigger",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.INSERT_without_column_list",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Asterisk_in_select_list",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.TOP_without_ORDER_BY",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Declaring_var_type_variables_without_length",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.CAST_CONVERT_to_var_types_without_length",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Avoid_var_types_of_length_1_or_2",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Usage_of_identity",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.NULL_comparison_or_addition_substring",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.CASE_without_ELSE",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.EXECUTE_string_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statement",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Scope_of_cursor_LOCAL_GLOBAL_is_not_specified",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Return_without_result_code",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DELETE_statement_without_WHERE_clause",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.UPDATE_statement_without_WHERE_clause",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incompatible_variable_type_for_procedure_call",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incompatible_literal_type_for_procedure_call",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Non_scalar_subquery_in_place_of_a_scalar",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Extra_parameter_passed",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Unnamed_call_after_named_call",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Required_parameter_is_not_passed",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Call_parameter_declared_as_output",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Call_parameter_is_not_declared_as_output",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Call_has_more_parameters_than_required",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.OPEN_of_undefined_cursor",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.FETCH_from_undefined_cursor",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.CLOSE_of_undefined_cursor",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.DEALLOCATE_of_undefined_cursor",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columns",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incorrect_number_of_fetch_variables",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Reference_to_procedure_in_other_database",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Hardcoded_current_database_name_in_procedure_call",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Missing_parameters_name_in_procedure_call",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTION",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTION",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Closing_of_unopened_cursor",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Fetch_from_unopened_cursor",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatable",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Stored_procedure_name_starts_with_sp_",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Executing_stored_procedure_without_getting_result",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Reference_to_function_in_other_database",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Reference_to_table_or_view_in_other_database",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Adding_NOT_NULL_column_without_default_value",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Avoid_using_ISNUMERIC___function",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.CGTIMETimed_out",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.CGUNPUnparsed_SQL",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Table_var_is_declared_but_never_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Temp_table_is_declared_but_never_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Unqualified_column_name",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Usage_of_sp_executesql__only_in_proc_trigger",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Variable_is_declared_but_never_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Parameter_is_declared_but_never_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Schema_name_for_procedure_is_not_specified",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Schema_name_for_table_or_view_is_not_specified",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Creation_of_table_by_SELECT_INTO_statement",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.INDEX_HINT_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.JOIN_HINT_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.TABLE_HINT_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.QUERY_HINT_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.SET_NOCOUNT_OFF_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.No_SET_NOCOUNT_ON_before_DML",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Interleaving_DDL_and_DML_in_stored_proc_trigger",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.PRINT_statement_is_used_in_trigger",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_trigger",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incorrect_usage_of_COUNT__",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.SET_FORCEPLAN_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_only",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Cursor_is_opened_but_is_not_deallocated",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incorrect_usage_of_const_UDF",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonly",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Script_should_end_with_GO",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Script_should_end_with_empty_line",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.There_should_be_no_USE_statement_in_batch",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Old_style_join_is_used__from_table1_table2",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Old_style_column_alias_via_EQUAL_sign",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Procedure_body_not_enclosed_with_BEGIN_END",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.SQL_92_style_cursor_declaration_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.IF_or_ELSE_without_BEGIN_END_block",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Old_style_TOP_clause_is_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Cursor_name_is_reused",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Non_named_parameter_style_used",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Avoid_using_GOTO_to_improve_readability",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Use_alias_for_all_table_sources",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Consider_using_table_variable_instead_of_temporary_table",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}


namespace Asos.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Asos.Core.Rules.Data.Attributes;
    using Asos.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;




    [LocalizedExportCodeAnalysisRule("RuleIdentities.Consider_using_temporary_table_instead_of_table_variable",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleName,
    ReturnStatementPresentProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRule : AsosSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentProblemDescription = "ReturnStatementPresentRule_ProblemDescription";
        private const string ReturnStatementPresentRuleName = "ReturnStatementPresentRule_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ReturnStatements);
        }
    }
}








 
namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.AvoidWaitForDelayRuleId",
    Constants.ResourceBaseName,
    AvoidWaitForDelayRuleIdRuleName,
    AvoidWaitForDelayRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class AvoidWaitForDelayRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string AvoidWaitForDelayRuleIdProblemDescription = "AvoidWaitForDelayRuleId_ProblemDescription";
        private const string AvoidWaitForDelayRuleIdRuleName = "AvoidWaitForDelayRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new AvoidWaitForDelayRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DoNotUseSelectAllRuleId",
    Constants.ResourceBaseName,
    DoNotUseSelectAllRuleIdRuleName,
    DoNotUseSelectAllRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DoNotUseSelectAllRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string DoNotUseSelectAllRuleIdProblemDescription = "DoNotUseSelectAllRuleId_ProblemDescription";
        private const string DoNotUseSelectAllRuleIdRuleName = "DoNotUseSelectAllRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DoNotUseSelectAllRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.KeywordsUppercaseRuleId",
    Constants.ResourceBaseName,
    KeywordsUppercaseRuleIdRuleName,
    KeywordsUppercaseRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class KeywordsUppercaseRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string KeywordsUppercaseRuleIdProblemDescription = "KeywordsUppercaseRuleId_ProblemDescription";
        private const string KeywordsUppercaseRuleIdRuleName = "KeywordsUppercaseRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new KeywordsUppercaseRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.TableAliasRuleId",
    Constants.ResourceBaseName,
    TableAliasRuleIdRuleName,
    TableAliasRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class TableAliasRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string TableAliasRuleIdProblemDescription = "TableAliasRuleId_ProblemDescription";
        private const string TableAliasRuleIdRuleName = "TableAliasRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new TableAliasRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.ColumnNamesMustBeSpecifiedRuleId",
    Constants.ResourceBaseName,
    ColumnNamesMustBeSpecifiedRuleIdRuleName,
    ColumnNamesMustBeSpecifiedRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ColumnNamesMustBeSpecifiedRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string ColumnNamesMustBeSpecifiedRuleIdProblemDescription = "ColumnNamesMustBeSpecifiedRuleId_ProblemDescription";
        private const string ColumnNamesMustBeSpecifiedRuleIdRuleName = "ColumnNamesMustBeSpecifiedRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ColumnNamesMustBeSpecifiedRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DoNotUseNumbersInOrderByRuleId",
    Constants.ResourceBaseName,
    DoNotUseNumbersInOrderByRuleIdRuleName,
    DoNotUseNumbersInOrderByRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DoNotUseNumbersInOrderByRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string DoNotUseNumbersInOrderByRuleIdProblemDescription = "DoNotUseNumbersInOrderByRuleId_ProblemDescription";
        private const string DoNotUseNumbersInOrderByRuleIdRuleName = "DoNotUseNumbersInOrderByRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DoNotUseNumbersInOrderByRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.SchemaPrefixRuleId",
    Constants.ResourceBaseName,
    SchemaPrefixRuleIdRuleName,
    SchemaPrefixRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class SchemaPrefixRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string SchemaPrefixRuleIdProblemDescription = "SchemaPrefixRuleId_ProblemDescription";
        private const string SchemaPrefixRuleIdRuleName = "SchemaPrefixRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new SchemaPrefixRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.JoinsMustNotBeInWhereClauseRuleId",
    Constants.ResourceBaseName,
    JoinsMustNotBeInWhereClauseRuleIdRuleName,
    JoinsMustNotBeInWhereClauseRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class JoinsMustNotBeInWhereClauseRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string JoinsMustNotBeInWhereClauseRuleIdProblemDescription = "JoinsMustNotBeInWhereClauseRuleId_ProblemDescription";
        private const string JoinsMustNotBeInWhereClauseRuleIdRuleName = "JoinsMustNotBeInWhereClauseRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new JoinsMustNotBeInWhereClauseRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.AvoidUsingSetOptionsRuleId",
    Constants.ResourceBaseName,
    AvoidUsingSetOptionsRuleIdRuleName,
    AvoidUsingSetOptionsRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class AvoidUsingSetOptionsRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string AvoidUsingSetOptionsRuleIdProblemDescription = "AvoidUsingSetOptionsRuleId_ProblemDescription";
        private const string AvoidUsingSetOptionsRuleIdRuleName = "AvoidUsingSetOptionsRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new AvoidUsingSetOptionsRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.ProhibitedTypesRuleId",
    Constants.ResourceBaseName,
    ProhibitedTypesRuleIdRuleName,
    ProhibitedTypesRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ProhibitedTypesRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string ProhibitedTypesRuleIdProblemDescription = "ProhibitedTypesRuleId_ProblemDescription";
        private const string ProhibitedTypesRuleIdRuleName = "ProhibitedTypesRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ProhibitedTypesRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.AvoidUsingGlobalVariableForIdentityRuleId",
    Constants.ResourceBaseName,
    AvoidUsingGlobalVariableForIdentityRuleIdRuleName,
    AvoidUsingGlobalVariableForIdentityRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class AvoidUsingGlobalVariableForIdentityRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string AvoidUsingGlobalVariableForIdentityRuleIdProblemDescription = "AvoidUsingGlobalVariableForIdentityRuleId_ProblemDescription";
        private const string AvoidUsingGlobalVariableForIdentityRuleIdRuleName = "AvoidUsingGlobalVariableForIdentityRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new AvoidUsingGlobalVariableForIdentityRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.UsingIndexedViewsRuleId",
    Constants.ResourceBaseName,
    UsingIndexedViewsRuleIdRuleName,
    UsingIndexedViewsRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class UsingIndexedViewsRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string UsingIndexedViewsRuleIdProblemDescription = "UsingIndexedViewsRuleId_ProblemDescription";
        private const string UsingIndexedViewsRuleIdRuleName = "UsingIndexedViewsRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new UsingIndexedViewsRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.FullTextIndexRuleId",
    Constants.ResourceBaseName,
    FullTextIndexRuleIdRuleName,
    FullTextIndexRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class FullTextIndexRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string FullTextIndexRuleIdProblemDescription = "FullTextIndexRuleId_ProblemDescription";
        private const string FullTextIndexRuleIdRuleName = "FullTextIndexRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new FullTextIndexRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.UsingIndexedViewsId",
    Constants.ResourceBaseName,
    UsingIndexedViewsIdRuleName,
    UsingIndexedViewsIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class UsingIndexedViewsIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string UsingIndexedViewsIdProblemDescription = "UsingIndexedViewsId_ProblemDescription";
        private const string UsingIndexedViewsIdRuleName = "UsingIndexedViewsId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new UsingIndexedViewsIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.PrimaryKeyRuleId",
    Constants.ResourceBaseName,
    PrimaryKeyRuleIdRuleName,
    PrimaryKeyRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class PrimaryKeyRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string PrimaryKeyRuleIdProblemDescription = "PrimaryKeyRuleId_ProblemDescription";
        private const string PrimaryKeyRuleIdRuleName = "PrimaryKeyRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new PrimaryKeyRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.CollationRuleId",
    Constants.ResourceBaseName,
    CollationRuleIdRuleName,
    CollationRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class CollationRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string CollationRuleIdProblemDescription = "CollationRuleId_ProblemDescription";
        private const string CollationRuleIdRuleName = "CollationRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CollationRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DynamicSqlRuleId",
    Constants.ResourceBaseName,
    DynamicSqlRuleIdRuleName,
    DynamicSqlRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DynamicSqlRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string DynamicSqlRuleIdProblemDescription = "DynamicSqlRuleId_ProblemDescription";
        private const string DynamicSqlRuleIdRuleName = "DynamicSqlRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DynamicSqlRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.BalancedNumberOfSetOptionsNoCountRuleId",
    Constants.ResourceBaseName,
    BalancedNumberOfSetOptionsNoCountRuleIdRuleName,
    BalancedNumberOfSetOptionsNoCountRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class BalancedNumberOfSetOptionsNoCountRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string BalancedNumberOfSetOptionsNoCountRuleIdProblemDescription = "BalancedNumberOfSetOptionsNoCountRuleId_ProblemDescription";
        private const string BalancedNumberOfSetOptionsNoCountRuleIdRuleName = "BalancedNumberOfSetOptionsNoCountRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new BalancedNumberOfSetOptionsNoCountRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.ReturnStatementPresentRuleId",
    Constants.ResourceBaseName,
    ReturnStatementPresentRuleIdRuleName,
    ReturnStatementPresentRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ReturnStatementPresentRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string ReturnStatementPresentRuleIdProblemDescription = "ReturnStatementPresentRuleId_ProblemDescription";
        private const string ReturnStatementPresentRuleIdRuleName = "ReturnStatementPresentRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ReturnStatementPresentRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DoNotUseHintsRuleId",
    Constants.ResourceBaseName,
    DoNotUseHintsRuleIdRuleName,
    DoNotUseHintsRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DoNotUseHintsRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string DoNotUseHintsRuleIdProblemDescription = "DoNotUseHintsRuleId_ProblemDescription";
        private const string DoNotUseHintsRuleIdRuleName = "DoNotUseHintsRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DoNotUseHintsRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DdlRuleId",
    Constants.ResourceBaseName,
    DdlRuleIdRuleName,
    DdlRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DdlRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string DdlRuleIdProblemDescription = "DdlRuleId_ProblemDescription";
        private const string DdlRuleIdRuleName = "DdlRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DdlRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.HeaderRuleId",
    Constants.ResourceBaseName,
    HeaderRuleIdRuleName,
    HeaderRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class HeaderRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string HeaderRuleIdProblemDescription = "HeaderRuleId_ProblemDescription";
        private const string HeaderRuleIdRuleName = "HeaderRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new HeaderRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DataTypesLowercaseRuleId",
    Constants.ResourceBaseName,
    DataTypesLowercaseRuleIdRuleName,
    DataTypesLowercaseRuleIdProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DataTypesLowercaseRuleIdRule : CarnageSqlCodeAnalysisRule
    {
        private const string DataTypesLowercaseRuleIdProblemDescription = "DataTypesLowercaseRuleId_ProblemDescription";
        private const string DataTypesLowercaseRuleIdRuleName = "DataTypesLowercaseRuleId_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DataTypesLowercaseRuleIdVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Index_Type_Is_Not_Specified",
    Constants.ResourceBaseName,
    Index_Type_Is_Not_SpecifiedRuleName,
    Index_Type_Is_Not_SpecifiedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Index_Type_Is_Not_SpecifiedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Index_Type_Is_Not_SpecifiedProblemDescription = "Index_Type_Is_Not_Specified_ProblemDescription";
        private const string Index_Type_Is_Not_SpecifiedRuleName = "Index_Type_Is_Not_Specified_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Index_Type_Is_Not_SpecifiedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.ORDER_BY_clause_with_constants",
    Constants.ResourceBaseName,
    ORDER_BY_clause_with_constantsRuleName,
    ORDER_BY_clause_with_constantsProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ORDER_BY_clause_with_constantsRule : CarnageSqlCodeAnalysisRule
    {
        private const string ORDER_BY_clause_with_constantsProblemDescription = "ORDER_BY_clause_with_constants_ProblemDescription";
        private const string ORDER_BY_clause_with_constantsRuleName = "ORDER_BY_clause_with_constants_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ORDER_BY_clause_with_constantsVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.SELECT_in_trigger",
    Constants.ResourceBaseName,
    SELECT_in_triggerRuleName,
    SELECT_in_triggerProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class SELECT_in_triggerRule : CarnageSqlCodeAnalysisRule
    {
        private const string SELECT_in_triggerProblemDescription = "SELECT_in_trigger_ProblemDescription";
        private const string SELECT_in_triggerRuleName = "SELECT_in_trigger_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new SELECT_in_triggerVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.INSERT_without_column_list",
    Constants.ResourceBaseName,
    INSERT_without_column_listRuleName,
    INSERT_without_column_listProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class INSERT_without_column_listRule : CarnageSqlCodeAnalysisRule
    {
        private const string INSERT_without_column_listProblemDescription = "INSERT_without_column_list_ProblemDescription";
        private const string INSERT_without_column_listRuleName = "INSERT_without_column_list_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new INSERT_without_column_listVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Asterisk_in_select_list",
    Constants.ResourceBaseName,
    Asterisk_in_select_listRuleName,
    Asterisk_in_select_listProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Asterisk_in_select_listRule : CarnageSqlCodeAnalysisRule
    {
        private const string Asterisk_in_select_listProblemDescription = "Asterisk_in_select_list_ProblemDescription";
        private const string Asterisk_in_select_listRuleName = "Asterisk_in_select_list_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Asterisk_in_select_listVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.TOP_without_ORDER_BY",
    Constants.ResourceBaseName,
    TOP_without_ORDER_BYRuleName,
    TOP_without_ORDER_BYProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class TOP_without_ORDER_BYRule : CarnageSqlCodeAnalysisRule
    {
        private const string TOP_without_ORDER_BYProblemDescription = "TOP_without_ORDER_BY_ProblemDescription";
        private const string TOP_without_ORDER_BYRuleName = "TOP_without_ORDER_BY_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new TOP_without_ORDER_BYVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Declaring_var_type_variables_without_length",
    Constants.ResourceBaseName,
    Declaring_var_type_variables_without_lengthRuleName,
    Declaring_var_type_variables_without_lengthProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Declaring_var_type_variables_without_lengthRule : CarnageSqlCodeAnalysisRule
    {
        private const string Declaring_var_type_variables_without_lengthProblemDescription = "Declaring_var_type_variables_without_length_ProblemDescription";
        private const string Declaring_var_type_variables_without_lengthRuleName = "Declaring_var_type_variables_without_length_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Declaring_var_type_variables_without_lengthVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.CAST_CONVERT_to_var_types_without_length",
    Constants.ResourceBaseName,
    CAST_CONVERT_to_var_types_without_lengthRuleName,
    CAST_CONVERT_to_var_types_without_lengthProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class CAST_CONVERT_to_var_types_without_lengthRule : CarnageSqlCodeAnalysisRule
    {
        private const string CAST_CONVERT_to_var_types_without_lengthProblemDescription = "CAST_CONVERT_to_var_types_without_length_ProblemDescription";
        private const string CAST_CONVERT_to_var_types_without_lengthRuleName = "CAST_CONVERT_to_var_types_without_length_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CAST_CONVERT_to_var_types_without_lengthVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Avoid_var_types_of_length_1_or_2",
    Constants.ResourceBaseName,
    Avoid_var_types_of_length_1_or_2RuleName,
    Avoid_var_types_of_length_1_or_2ProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Avoid_var_types_of_length_1_or_2Rule : CarnageSqlCodeAnalysisRule
    {
        private const string Avoid_var_types_of_length_1_or_2ProblemDescription = "Avoid_var_types_of_length_1_or_2_ProblemDescription";
        private const string Avoid_var_types_of_length_1_or_2RuleName = "Avoid_var_types_of_length_1_or_2_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Avoid_var_types_of_length_1_or_2Visitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Usage_of_identity",
    Constants.ResourceBaseName,
    Usage_of_identityRuleName,
    Usage_of_identityProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Usage_of_identityRule : CarnageSqlCodeAnalysisRule
    {
        private const string Usage_of_identityProblemDescription = "Usage_of_identity_ProblemDescription";
        private const string Usage_of_identityRuleName = "Usage_of_identity_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Usage_of_identityVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.NULL_comparison_or_addition_substring",
    Constants.ResourceBaseName,
    NULL_comparison_or_addition_substringRuleName,
    NULL_comparison_or_addition_substringProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class NULL_comparison_or_addition_substringRule : CarnageSqlCodeAnalysisRule
    {
        private const string NULL_comparison_or_addition_substringProblemDescription = "NULL_comparison_or_addition_substring_ProblemDescription";
        private const string NULL_comparison_or_addition_substringRuleName = "NULL_comparison_or_addition_substring_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new NULL_comparison_or_addition_substringVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.CASE_without_ELSE",
    Constants.ResourceBaseName,
    CASE_without_ELSERuleName,
    CASE_without_ELSEProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class CASE_without_ELSERule : CarnageSqlCodeAnalysisRule
    {
        private const string CASE_without_ELSEProblemDescription = "CASE_without_ELSE_ProblemDescription";
        private const string CASE_without_ELSERuleName = "CASE_without_ELSE_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CASE_without_ELSEVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.EXECUTE_string_is_used",
    Constants.ResourceBaseName,
    EXECUTE_string_is_usedRuleName,
    EXECUTE_string_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class EXECUTE_string_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string EXECUTE_string_is_usedProblemDescription = "EXECUTE_string_is_used_ProblemDescription";
        private const string EXECUTE_string_is_usedRuleName = "EXECUTE_string_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new EXECUTE_string_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statement",
    Constants.ResourceBaseName,
    NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementRuleName,
    NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementRule : CarnageSqlCodeAnalysisRule
    {
        private const string NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementProblemDescription = "NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statement_ProblemDescription";
        private const string NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementRuleName = "NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statement_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Scope_of_cursor_LOCAL_GLOBAL_is_not_specified",
    Constants.ResourceBaseName,
    Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedRuleName,
    Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedProblemDescription = "Scope_of_cursor_LOCAL_GLOBAL_is_not_specified_ProblemDescription";
        private const string Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedRuleName = "Scope_of_cursor_LOCAL_GLOBAL_is_not_specified_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Return_without_result_code",
    Constants.ResourceBaseName,
    Return_without_result_codeRuleName,
    Return_without_result_codeProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Return_without_result_codeRule : CarnageSqlCodeAnalysisRule
    {
        private const string Return_without_result_codeProblemDescription = "Return_without_result_code_ProblemDescription";
        private const string Return_without_result_codeRuleName = "Return_without_result_code_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Return_without_result_codeVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DELETE_statement_without_WHERE_clause",
    Constants.ResourceBaseName,
    DELETE_statement_without_WHERE_clauseRuleName,
    DELETE_statement_without_WHERE_clauseProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DELETE_statement_without_WHERE_clauseRule : CarnageSqlCodeAnalysisRule
    {
        private const string DELETE_statement_without_WHERE_clauseProblemDescription = "DELETE_statement_without_WHERE_clause_ProblemDescription";
        private const string DELETE_statement_without_WHERE_clauseRuleName = "DELETE_statement_without_WHERE_clause_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DELETE_statement_without_WHERE_clauseVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.UPDATE_statement_without_WHERE_clause",
    Constants.ResourceBaseName,
    UPDATE_statement_without_WHERE_clauseRuleName,
    UPDATE_statement_without_WHERE_clauseProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class UPDATE_statement_without_WHERE_clauseRule : CarnageSqlCodeAnalysisRule
    {
        private const string UPDATE_statement_without_WHERE_clauseProblemDescription = "UPDATE_statement_without_WHERE_clause_ProblemDescription";
        private const string UPDATE_statement_without_WHERE_clauseRuleName = "UPDATE_statement_without_WHERE_clause_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new UPDATE_statement_without_WHERE_clauseVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incompatible_variable_type_for_procedure_call",
    Constants.ResourceBaseName,
    Incompatible_variable_type_for_procedure_callRuleName,
    Incompatible_variable_type_for_procedure_callProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Incompatible_variable_type_for_procedure_callRule : CarnageSqlCodeAnalysisRule
    {
        private const string Incompatible_variable_type_for_procedure_callProblemDescription = "Incompatible_variable_type_for_procedure_call_ProblemDescription";
        private const string Incompatible_variable_type_for_procedure_callRuleName = "Incompatible_variable_type_for_procedure_call_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Incompatible_variable_type_for_procedure_callVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incompatible_literal_type_for_procedure_call",
    Constants.ResourceBaseName,
    Incompatible_literal_type_for_procedure_callRuleName,
    Incompatible_literal_type_for_procedure_callProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Incompatible_literal_type_for_procedure_callRule : CarnageSqlCodeAnalysisRule
    {
        private const string Incompatible_literal_type_for_procedure_callProblemDescription = "Incompatible_literal_type_for_procedure_call_ProblemDescription";
        private const string Incompatible_literal_type_for_procedure_callRuleName = "Incompatible_literal_type_for_procedure_call_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Incompatible_literal_type_for_procedure_callVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Non_scalar_subquery_in_place_of_a_scalar",
    Constants.ResourceBaseName,
    Non_scalar_subquery_in_place_of_a_scalarRuleName,
    Non_scalar_subquery_in_place_of_a_scalarProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Non_scalar_subquery_in_place_of_a_scalarRule : CarnageSqlCodeAnalysisRule
    {
        private const string Non_scalar_subquery_in_place_of_a_scalarProblemDescription = "Non_scalar_subquery_in_place_of_a_scalar_ProblemDescription";
        private const string Non_scalar_subquery_in_place_of_a_scalarRuleName = "Non_scalar_subquery_in_place_of_a_scalar_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Non_scalar_subquery_in_place_of_a_scalarVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Extra_parameter_passed",
    Constants.ResourceBaseName,
    Extra_parameter_passedRuleName,
    Extra_parameter_passedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Extra_parameter_passedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Extra_parameter_passedProblemDescription = "Extra_parameter_passed_ProblemDescription";
        private const string Extra_parameter_passedRuleName = "Extra_parameter_passed_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Extra_parameter_passedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Unnamed_call_after_named_call",
    Constants.ResourceBaseName,
    Unnamed_call_after_named_callRuleName,
    Unnamed_call_after_named_callProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Unnamed_call_after_named_callRule : CarnageSqlCodeAnalysisRule
    {
        private const string Unnamed_call_after_named_callProblemDescription = "Unnamed_call_after_named_call_ProblemDescription";
        private const string Unnamed_call_after_named_callRuleName = "Unnamed_call_after_named_call_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Unnamed_call_after_named_callVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Required_parameter_is_not_passed",
    Constants.ResourceBaseName,
    Required_parameter_is_not_passedRuleName,
    Required_parameter_is_not_passedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Required_parameter_is_not_passedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Required_parameter_is_not_passedProblemDescription = "Required_parameter_is_not_passed_ProblemDescription";
        private const string Required_parameter_is_not_passedRuleName = "Required_parameter_is_not_passed_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Required_parameter_is_not_passedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Call_parameter_declared_as_output",
    Constants.ResourceBaseName,
    Call_parameter_declared_as_outputRuleName,
    Call_parameter_declared_as_outputProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Call_parameter_declared_as_outputRule : CarnageSqlCodeAnalysisRule
    {
        private const string Call_parameter_declared_as_outputProblemDescription = "Call_parameter_declared_as_output_ProblemDescription";
        private const string Call_parameter_declared_as_outputRuleName = "Call_parameter_declared_as_output_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Call_parameter_declared_as_outputVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Call_parameter_is_not_declared_as_output",
    Constants.ResourceBaseName,
    Call_parameter_is_not_declared_as_outputRuleName,
    Call_parameter_is_not_declared_as_outputProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Call_parameter_is_not_declared_as_outputRule : CarnageSqlCodeAnalysisRule
    {
        private const string Call_parameter_is_not_declared_as_outputProblemDescription = "Call_parameter_is_not_declared_as_output_ProblemDescription";
        private const string Call_parameter_is_not_declared_as_outputRuleName = "Call_parameter_is_not_declared_as_output_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Call_parameter_is_not_declared_as_outputVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Call_has_more_parameters_than_required",
    Constants.ResourceBaseName,
    Call_has_more_parameters_than_requiredRuleName,
    Call_has_more_parameters_than_requiredProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Call_has_more_parameters_than_requiredRule : CarnageSqlCodeAnalysisRule
    {
        private const string Call_has_more_parameters_than_requiredProblemDescription = "Call_has_more_parameters_than_required_ProblemDescription";
        private const string Call_has_more_parameters_than_requiredRuleName = "Call_has_more_parameters_than_required_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Call_has_more_parameters_than_requiredVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.OPEN_of_undefined_cursor",
    Constants.ResourceBaseName,
    OPEN_of_undefined_cursorRuleName,
    OPEN_of_undefined_cursorProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class OPEN_of_undefined_cursorRule : CarnageSqlCodeAnalysisRule
    {
        private const string OPEN_of_undefined_cursorProblemDescription = "OPEN_of_undefined_cursor_ProblemDescription";
        private const string OPEN_of_undefined_cursorRuleName = "OPEN_of_undefined_cursor_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new OPEN_of_undefined_cursorVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.FETCH_from_undefined_cursor",
    Constants.ResourceBaseName,
    FETCH_from_undefined_cursorRuleName,
    FETCH_from_undefined_cursorProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class FETCH_from_undefined_cursorRule : CarnageSqlCodeAnalysisRule
    {
        private const string FETCH_from_undefined_cursorProblemDescription = "FETCH_from_undefined_cursor_ProblemDescription";
        private const string FETCH_from_undefined_cursorRuleName = "FETCH_from_undefined_cursor_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new FETCH_from_undefined_cursorVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.CLOSE_of_undefined_cursor",
    Constants.ResourceBaseName,
    CLOSE_of_undefined_cursorRuleName,
    CLOSE_of_undefined_cursorProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class CLOSE_of_undefined_cursorRule : CarnageSqlCodeAnalysisRule
    {
        private const string CLOSE_of_undefined_cursorProblemDescription = "CLOSE_of_undefined_cursor_ProblemDescription";
        private const string CLOSE_of_undefined_cursorRuleName = "CLOSE_of_undefined_cursor_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CLOSE_of_undefined_cursorVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.DEALLOCATE_of_undefined_cursor",
    Constants.ResourceBaseName,
    DEALLOCATE_of_undefined_cursorRuleName,
    DEALLOCATE_of_undefined_cursorProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class DEALLOCATE_of_undefined_cursorRule : CarnageSqlCodeAnalysisRule
    {
        private const string DEALLOCATE_of_undefined_cursorProblemDescription = "DEALLOCATE_of_undefined_cursor_ProblemDescription";
        private const string DEALLOCATE_of_undefined_cursorRuleName = "DEALLOCATE_of_undefined_cursor_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new DEALLOCATE_of_undefined_cursorVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columns",
    Constants.ResourceBaseName,
    Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsRuleName,
    Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsRule : CarnageSqlCodeAnalysisRule
    {
        private const string Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsProblemDescription = "Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columns_ProblemDescription";
        private const string Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsRuleName = "Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columns_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incorrect_number_of_fetch_variables",
    Constants.ResourceBaseName,
    Incorrect_number_of_fetch_variablesRuleName,
    Incorrect_number_of_fetch_variablesProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Incorrect_number_of_fetch_variablesRule : CarnageSqlCodeAnalysisRule
    {
        private const string Incorrect_number_of_fetch_variablesProblemDescription = "Incorrect_number_of_fetch_variables_ProblemDescription";
        private const string Incorrect_number_of_fetch_variablesRuleName = "Incorrect_number_of_fetch_variables_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Incorrect_number_of_fetch_variablesVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Reference_to_procedure_in_other_database",
    Constants.ResourceBaseName,
    Reference_to_procedure_in_other_databaseRuleName,
    Reference_to_procedure_in_other_databaseProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Reference_to_procedure_in_other_databaseRule : CarnageSqlCodeAnalysisRule
    {
        private const string Reference_to_procedure_in_other_databaseProblemDescription = "Reference_to_procedure_in_other_database_ProblemDescription";
        private const string Reference_to_procedure_in_other_databaseRuleName = "Reference_to_procedure_in_other_database_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Reference_to_procedure_in_other_databaseVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Hardcoded_current_database_name_in_procedure_call",
    Constants.ResourceBaseName,
    Hardcoded_current_database_name_in_procedure_callRuleName,
    Hardcoded_current_database_name_in_procedure_callProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Hardcoded_current_database_name_in_procedure_callRule : CarnageSqlCodeAnalysisRule
    {
        private const string Hardcoded_current_database_name_in_procedure_callProblemDescription = "Hardcoded_current_database_name_in_procedure_call_ProblemDescription";
        private const string Hardcoded_current_database_name_in_procedure_callRuleName = "Hardcoded_current_database_name_in_procedure_call_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Hardcoded_current_database_name_in_procedure_callVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Missing_parameters_name_in_procedure_call",
    Constants.ResourceBaseName,
    Missing_parameters_name_in_procedure_callRuleName,
    Missing_parameters_name_in_procedure_callProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Missing_parameters_name_in_procedure_callRule : CarnageSqlCodeAnalysisRule
    {
        private const string Missing_parameters_name_in_procedure_callProblemDescription = "Missing_parameters_name_in_procedure_call_ProblemDescription";
        private const string Missing_parameters_name_in_procedure_callRuleName = "Missing_parameters_name_in_procedure_call_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Missing_parameters_name_in_procedure_callVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTION",
    Constants.ResourceBaseName,
    BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONRuleName,
    BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONRule : CarnageSqlCodeAnalysisRule
    {
        private const string BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONProblemDescription = "BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTION_ProblemDescription";
        private const string BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONRuleName = "BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTION_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTION",
    Constants.ResourceBaseName,
    ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONRuleName,
    ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONRule : CarnageSqlCodeAnalysisRule
    {
        private const string ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONProblemDescription = "ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTION_ProblemDescription";
        private const string ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONRuleName = "ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTION_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Closing_of_unopened_cursor",
    Constants.ResourceBaseName,
    Closing_of_unopened_cursorRuleName,
    Closing_of_unopened_cursorProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Closing_of_unopened_cursorRule : CarnageSqlCodeAnalysisRule
    {
        private const string Closing_of_unopened_cursorProblemDescription = "Closing_of_unopened_cursor_ProblemDescription";
        private const string Closing_of_unopened_cursorRuleName = "Closing_of_unopened_cursor_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Closing_of_unopened_cursorVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Fetch_from_unopened_cursor",
    Constants.ResourceBaseName,
    Fetch_from_unopened_cursorRuleName,
    Fetch_from_unopened_cursorProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Fetch_from_unopened_cursorRule : CarnageSqlCodeAnalysisRule
    {
        private const string Fetch_from_unopened_cursorProblemDescription = "Fetch_from_unopened_cursor_ProblemDescription";
        private const string Fetch_from_unopened_cursorRuleName = "Fetch_from_unopened_cursor_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Fetch_from_unopened_cursorVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatable",
    Constants.ResourceBaseName,
    Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableRuleName,
    Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableRule : CarnageSqlCodeAnalysisRule
    {
        private const string Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableProblemDescription = "Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatable_ProblemDescription";
        private const string Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableRuleName = "Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatable_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Stored_procedure_name_starts_with_sp_",
    Constants.ResourceBaseName,
    Stored_procedure_name_starts_with_sp_RuleName,
    Stored_procedure_name_starts_with_sp_ProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Stored_procedure_name_starts_with_sp_Rule : CarnageSqlCodeAnalysisRule
    {
        private const string Stored_procedure_name_starts_with_sp_ProblemDescription = "Stored_procedure_name_starts_with_sp__ProblemDescription";
        private const string Stored_procedure_name_starts_with_sp_RuleName = "Stored_procedure_name_starts_with_sp__RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Stored_procedure_name_starts_with_sp_Visitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Executing_stored_procedure_without_getting_result",
    Constants.ResourceBaseName,
    Executing_stored_procedure_without_getting_resultRuleName,
    Executing_stored_procedure_without_getting_resultProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Executing_stored_procedure_without_getting_resultRule : CarnageSqlCodeAnalysisRule
    {
        private const string Executing_stored_procedure_without_getting_resultProblemDescription = "Executing_stored_procedure_without_getting_result_ProblemDescription";
        private const string Executing_stored_procedure_without_getting_resultRuleName = "Executing_stored_procedure_without_getting_result_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Executing_stored_procedure_without_getting_resultVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Reference_to_function_in_other_database",
    Constants.ResourceBaseName,
    Reference_to_function_in_other_databaseRuleName,
    Reference_to_function_in_other_databaseProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Reference_to_function_in_other_databaseRule : CarnageSqlCodeAnalysisRule
    {
        private const string Reference_to_function_in_other_databaseProblemDescription = "Reference_to_function_in_other_database_ProblemDescription";
        private const string Reference_to_function_in_other_databaseRuleName = "Reference_to_function_in_other_database_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Reference_to_function_in_other_databaseVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Reference_to_table_or_view_in_other_database",
    Constants.ResourceBaseName,
    Reference_to_table_or_view_in_other_databaseRuleName,
    Reference_to_table_or_view_in_other_databaseProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Reference_to_table_or_view_in_other_databaseRule : CarnageSqlCodeAnalysisRule
    {
        private const string Reference_to_table_or_view_in_other_databaseProblemDescription = "Reference_to_table_or_view_in_other_database_ProblemDescription";
        private const string Reference_to_table_or_view_in_other_databaseRuleName = "Reference_to_table_or_view_in_other_database_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Reference_to_table_or_view_in_other_databaseVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Adding_NOT_NULL_column_without_default_value",
    Constants.ResourceBaseName,
    Adding_NOT_NULL_column_without_default_valueRuleName,
    Adding_NOT_NULL_column_without_default_valueProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Adding_NOT_NULL_column_without_default_valueRule : CarnageSqlCodeAnalysisRule
    {
        private const string Adding_NOT_NULL_column_without_default_valueProblemDescription = "Adding_NOT_NULL_column_without_default_value_ProblemDescription";
        private const string Adding_NOT_NULL_column_without_default_valueRuleName = "Adding_NOT_NULL_column_without_default_value_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Adding_NOT_NULL_column_without_default_valueVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Avoid_using_ISNUMERIC___function",
    Constants.ResourceBaseName,
    Avoid_using_ISNUMERIC___functionRuleName,
    Avoid_using_ISNUMERIC___functionProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Avoid_using_ISNUMERIC___functionRule : CarnageSqlCodeAnalysisRule
    {
        private const string Avoid_using_ISNUMERIC___functionProblemDescription = "Avoid_using_ISNUMERIC___function_ProblemDescription";
        private const string Avoid_using_ISNUMERIC___functionRuleName = "Avoid_using_ISNUMERIC___function_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Avoid_using_ISNUMERIC___functionVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.CGTIMETimed_out",
    Constants.ResourceBaseName,
    CGTIMETimed_outRuleName,
    CGTIMETimed_outProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class CGTIMETimed_outRule : CarnageSqlCodeAnalysisRule
    {
        private const string CGTIMETimed_outProblemDescription = "CGTIMETimed_out_ProblemDescription";
        private const string CGTIMETimed_outRuleName = "CGTIMETimed_out_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CGTIMETimed_outVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.CGUNPUnparsed_SQL",
    Constants.ResourceBaseName,
    CGUNPUnparsed_SQLRuleName,
    CGUNPUnparsed_SQLProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class CGUNPUnparsed_SQLRule : CarnageSqlCodeAnalysisRule
    {
        private const string CGUNPUnparsed_SQLProblemDescription = "CGUNPUnparsed_SQL_ProblemDescription";
        private const string CGUNPUnparsed_SQLRuleName = "CGUNPUnparsed_SQL_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new CGUNPUnparsed_SQLVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Table_var_is_declared_but_never_used",
    Constants.ResourceBaseName,
    Table_var_is_declared_but_never_usedRuleName,
    Table_var_is_declared_but_never_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Table_var_is_declared_but_never_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Table_var_is_declared_but_never_usedProblemDescription = "Table_var_is_declared_but_never_used_ProblemDescription";
        private const string Table_var_is_declared_but_never_usedRuleName = "Table_var_is_declared_but_never_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Table_var_is_declared_but_never_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Temp_table_is_declared_but_never_used",
    Constants.ResourceBaseName,
    Temp_table_is_declared_but_never_usedRuleName,
    Temp_table_is_declared_but_never_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Temp_table_is_declared_but_never_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Temp_table_is_declared_but_never_usedProblemDescription = "Temp_table_is_declared_but_never_used_ProblemDescription";
        private const string Temp_table_is_declared_but_never_usedRuleName = "Temp_table_is_declared_but_never_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Temp_table_is_declared_but_never_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Unqualified_column_name",
    Constants.ResourceBaseName,
    Unqualified_column_nameRuleName,
    Unqualified_column_nameProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Unqualified_column_nameRule : CarnageSqlCodeAnalysisRule
    {
        private const string Unqualified_column_nameProblemDescription = "Unqualified_column_name_ProblemDescription";
        private const string Unqualified_column_nameRuleName = "Unqualified_column_name_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Unqualified_column_nameVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Usage_of_sp_executesql__only_in_proc_trigger",
    Constants.ResourceBaseName,
    Usage_of_sp_executesql__only_in_proc_triggerRuleName,
    Usage_of_sp_executesql__only_in_proc_triggerProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Usage_of_sp_executesql__only_in_proc_triggerRule : CarnageSqlCodeAnalysisRule
    {
        private const string Usage_of_sp_executesql__only_in_proc_triggerProblemDescription = "Usage_of_sp_executesql__only_in_proc_trigger_ProblemDescription";
        private const string Usage_of_sp_executesql__only_in_proc_triggerRuleName = "Usage_of_sp_executesql__only_in_proc_trigger_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Usage_of_sp_executesql__only_in_proc_triggerVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Variable_is_declared_but_never_used",
    Constants.ResourceBaseName,
    Variable_is_declared_but_never_usedRuleName,
    Variable_is_declared_but_never_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Variable_is_declared_but_never_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Variable_is_declared_but_never_usedProblemDescription = "Variable_is_declared_but_never_used_ProblemDescription";
        private const string Variable_is_declared_but_never_usedRuleName = "Variable_is_declared_but_never_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Variable_is_declared_but_never_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Parameter_is_declared_but_never_used",
    Constants.ResourceBaseName,
    Parameter_is_declared_but_never_usedRuleName,
    Parameter_is_declared_but_never_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Parameter_is_declared_but_never_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Parameter_is_declared_but_never_usedProblemDescription = "Parameter_is_declared_but_never_used_ProblemDescription";
        private const string Parameter_is_declared_but_never_usedRuleName = "Parameter_is_declared_but_never_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Parameter_is_declared_but_never_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Schema_name_for_procedure_is_not_specified",
    Constants.ResourceBaseName,
    Schema_name_for_procedure_is_not_specifiedRuleName,
    Schema_name_for_procedure_is_not_specifiedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Schema_name_for_procedure_is_not_specifiedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Schema_name_for_procedure_is_not_specifiedProblemDescription = "Schema_name_for_procedure_is_not_specified_ProblemDescription";
        private const string Schema_name_for_procedure_is_not_specifiedRuleName = "Schema_name_for_procedure_is_not_specified_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Schema_name_for_procedure_is_not_specifiedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Schema_name_for_table_or_view_is_not_specified",
    Constants.ResourceBaseName,
    Schema_name_for_table_or_view_is_not_specifiedRuleName,
    Schema_name_for_table_or_view_is_not_specifiedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Schema_name_for_table_or_view_is_not_specifiedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Schema_name_for_table_or_view_is_not_specifiedProblemDescription = "Schema_name_for_table_or_view_is_not_specified_ProblemDescription";
        private const string Schema_name_for_table_or_view_is_not_specifiedRuleName = "Schema_name_for_table_or_view_is_not_specified_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Schema_name_for_table_or_view_is_not_specifiedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Creation_of_table_by_SELECT_INTO_statement",
    Constants.ResourceBaseName,
    Creation_of_table_by_SELECT_INTO_statementRuleName,
    Creation_of_table_by_SELECT_INTO_statementProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Creation_of_table_by_SELECT_INTO_statementRule : CarnageSqlCodeAnalysisRule
    {
        private const string Creation_of_table_by_SELECT_INTO_statementProblemDescription = "Creation_of_table_by_SELECT_INTO_statement_ProblemDescription";
        private const string Creation_of_table_by_SELECT_INTO_statementRuleName = "Creation_of_table_by_SELECT_INTO_statement_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Creation_of_table_by_SELECT_INTO_statementVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.INDEX_HINT_is_used",
    Constants.ResourceBaseName,
    INDEX_HINT_is_usedRuleName,
    INDEX_HINT_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class INDEX_HINT_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string INDEX_HINT_is_usedProblemDescription = "INDEX_HINT_is_used_ProblemDescription";
        private const string INDEX_HINT_is_usedRuleName = "INDEX_HINT_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new INDEX_HINT_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.JOIN_HINT_is_used",
    Constants.ResourceBaseName,
    JOIN_HINT_is_usedRuleName,
    JOIN_HINT_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class JOIN_HINT_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string JOIN_HINT_is_usedProblemDescription = "JOIN_HINT_is_used_ProblemDescription";
        private const string JOIN_HINT_is_usedRuleName = "JOIN_HINT_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new JOIN_HINT_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.TABLE_HINT_is_used",
    Constants.ResourceBaseName,
    TABLE_HINT_is_usedRuleName,
    TABLE_HINT_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class TABLE_HINT_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string TABLE_HINT_is_usedProblemDescription = "TABLE_HINT_is_used_ProblemDescription";
        private const string TABLE_HINT_is_usedRuleName = "TABLE_HINT_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new TABLE_HINT_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.QUERY_HINT_is_used",
    Constants.ResourceBaseName,
    QUERY_HINT_is_usedRuleName,
    QUERY_HINT_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class QUERY_HINT_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string QUERY_HINT_is_usedProblemDescription = "QUERY_HINT_is_used_ProblemDescription";
        private const string QUERY_HINT_is_usedRuleName = "QUERY_HINT_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new QUERY_HINT_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.SET_NOCOUNT_OFF_is_used",
    Constants.ResourceBaseName,
    SET_NOCOUNT_OFF_is_usedRuleName,
    SET_NOCOUNT_OFF_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class SET_NOCOUNT_OFF_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string SET_NOCOUNT_OFF_is_usedProblemDescription = "SET_NOCOUNT_OFF_is_used_ProblemDescription";
        private const string SET_NOCOUNT_OFF_is_usedRuleName = "SET_NOCOUNT_OFF_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new SET_NOCOUNT_OFF_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.No_SET_NOCOUNT_ON_before_DML",
    Constants.ResourceBaseName,
    No_SET_NOCOUNT_ON_before_DMLRuleName,
    No_SET_NOCOUNT_ON_before_DMLProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class No_SET_NOCOUNT_ON_before_DMLRule : CarnageSqlCodeAnalysisRule
    {
        private const string No_SET_NOCOUNT_ON_before_DMLProblemDescription = "No_SET_NOCOUNT_ON_before_DML_ProblemDescription";
        private const string No_SET_NOCOUNT_ON_before_DMLRuleName = "No_SET_NOCOUNT_ON_before_DML_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new No_SET_NOCOUNT_ON_before_DMLVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Interleaving_DDL_and_DML_in_stored_proc_trigger",
    Constants.ResourceBaseName,
    Interleaving_DDL_and_DML_in_stored_proc_triggerRuleName,
    Interleaving_DDL_and_DML_in_stored_proc_triggerProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Interleaving_DDL_and_DML_in_stored_proc_triggerRule : CarnageSqlCodeAnalysisRule
    {
        private const string Interleaving_DDL_and_DML_in_stored_proc_triggerProblemDescription = "Interleaving_DDL_and_DML_in_stored_proc_trigger_ProblemDescription";
        private const string Interleaving_DDL_and_DML_in_stored_proc_triggerRuleName = "Interleaving_DDL_and_DML_in_stored_proc_trigger_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Interleaving_DDL_and_DML_in_stored_proc_triggerVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.PRINT_statement_is_used_in_trigger",
    Constants.ResourceBaseName,
    PRINT_statement_is_used_in_triggerRuleName,
    PRINT_statement_is_used_in_triggerProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class PRINT_statement_is_used_in_triggerRule : CarnageSqlCodeAnalysisRule
    {
        private const string PRINT_statement_is_used_in_triggerProblemDescription = "PRINT_statement_is_used_in_trigger_ProblemDescription";
        private const string PRINT_statement_is_used_in_triggerRuleName = "PRINT_statement_is_used_in_trigger_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new PRINT_statement_is_used_in_triggerVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_trigger",
    Constants.ResourceBaseName,
    Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerRuleName,
    Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerRule : CarnageSqlCodeAnalysisRule
    {
        private const string Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerProblemDescription = "Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_trigger_ProblemDescription";
        private const string Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerRuleName = "Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_trigger_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incorrect_usage_of_COUNT__",
    Constants.ResourceBaseName,
    Incorrect_usage_of_COUNT__RuleName,
    Incorrect_usage_of_COUNT__ProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Incorrect_usage_of_COUNT__Rule : CarnageSqlCodeAnalysisRule
    {
        private const string Incorrect_usage_of_COUNT__ProblemDescription = "Incorrect_usage_of_COUNT___ProblemDescription";
        private const string Incorrect_usage_of_COUNT__RuleName = "Incorrect_usage_of_COUNT___RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Incorrect_usage_of_COUNT__Visitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.SET_FORCEPLAN_used",
    Constants.ResourceBaseName,
    SET_FORCEPLAN_usedRuleName,
    SET_FORCEPLAN_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class SET_FORCEPLAN_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string SET_FORCEPLAN_usedProblemDescription = "SET_FORCEPLAN_used_ProblemDescription";
        private const string SET_FORCEPLAN_usedRuleName = "SET_FORCEPLAN_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new SET_FORCEPLAN_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_only",
    Constants.ResourceBaseName,
    No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyRuleName,
    No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyRule : CarnageSqlCodeAnalysisRule
    {
        private const string No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyProblemDescription = "No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_only_ProblemDescription";
        private const string No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyRuleName = "No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_only_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Cursor_is_opened_but_is_not_deallocated",
    Constants.ResourceBaseName,
    Cursor_is_opened_but_is_not_deallocatedRuleName,
    Cursor_is_opened_but_is_not_deallocatedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Cursor_is_opened_but_is_not_deallocatedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Cursor_is_opened_but_is_not_deallocatedProblemDescription = "Cursor_is_opened_but_is_not_deallocated_ProblemDescription";
        private const string Cursor_is_opened_but_is_not_deallocatedRuleName = "Cursor_is_opened_but_is_not_deallocated_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Cursor_is_opened_but_is_not_deallocatedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Incorrect_usage_of_const_UDF",
    Constants.ResourceBaseName,
    Incorrect_usage_of_const_UDFRuleName,
    Incorrect_usage_of_const_UDFProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Incorrect_usage_of_const_UDFRule : CarnageSqlCodeAnalysisRule
    {
        private const string Incorrect_usage_of_const_UDFProblemDescription = "Incorrect_usage_of_const_UDF_ProblemDescription";
        private const string Incorrect_usage_of_const_UDFRuleName = "Incorrect_usage_of_const_UDF_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Incorrect_usage_of_const_UDFVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonly",
    Constants.ResourceBaseName,
    No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyRuleName,
    No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyRule : CarnageSqlCodeAnalysisRule
    {
        private const string No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyProblemDescription = "No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonly_ProblemDescription";
        private const string No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyRuleName = "No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonly_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_",
    Constants.ResourceBaseName,
    Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_RuleName,
    Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_ProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_Rule : CarnageSqlCodeAnalysisRule
    {
        private const string Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_ProblemDescription = "Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery__ProblemDescription";
        private const string Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_RuleName = "Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery__RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_Visitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Script_should_end_with_GO",
    Constants.ResourceBaseName,
    Script_should_end_with_GORuleName,
    Script_should_end_with_GOProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Script_should_end_with_GORule : CarnageSqlCodeAnalysisRule
    {
        private const string Script_should_end_with_GOProblemDescription = "Script_should_end_with_GO_ProblemDescription";
        private const string Script_should_end_with_GORuleName = "Script_should_end_with_GO_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Script_should_end_with_GOVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Script_should_end_with_empty_line",
    Constants.ResourceBaseName,
    Script_should_end_with_empty_lineRuleName,
    Script_should_end_with_empty_lineProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Script_should_end_with_empty_lineRule : CarnageSqlCodeAnalysisRule
    {
        private const string Script_should_end_with_empty_lineProblemDescription = "Script_should_end_with_empty_line_ProblemDescription";
        private const string Script_should_end_with_empty_lineRuleName = "Script_should_end_with_empty_line_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Script_should_end_with_empty_lineVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.There_should_be_no_USE_statement_in_batch",
    Constants.ResourceBaseName,
    There_should_be_no_USE_statement_in_batchRuleName,
    There_should_be_no_USE_statement_in_batchProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class There_should_be_no_USE_statement_in_batchRule : CarnageSqlCodeAnalysisRule
    {
        private const string There_should_be_no_USE_statement_in_batchProblemDescription = "There_should_be_no_USE_statement_in_batch_ProblemDescription";
        private const string There_should_be_no_USE_statement_in_batchRuleName = "There_should_be_no_USE_statement_in_batch_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new There_should_be_no_USE_statement_in_batchVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Old_style_join_is_used__from_table1_table2",
    Constants.ResourceBaseName,
    Old_style_join_is_used__from_table1_table2RuleName,
    Old_style_join_is_used__from_table1_table2ProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Old_style_join_is_used__from_table1_table2Rule : CarnageSqlCodeAnalysisRule
    {
        private const string Old_style_join_is_used__from_table1_table2ProblemDescription = "Old_style_join_is_used__from_table1_table2_ProblemDescription";
        private const string Old_style_join_is_used__from_table1_table2RuleName = "Old_style_join_is_used__from_table1_table2_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Old_style_join_is_used__from_table1_table2Visitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Old_style_column_alias_via_EQUAL_sign",
    Constants.ResourceBaseName,
    Old_style_column_alias_via_EQUAL_signRuleName,
    Old_style_column_alias_via_EQUAL_signProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Old_style_column_alias_via_EQUAL_signRule : CarnageSqlCodeAnalysisRule
    {
        private const string Old_style_column_alias_via_EQUAL_signProblemDescription = "Old_style_column_alias_via_EQUAL_sign_ProblemDescription";
        private const string Old_style_column_alias_via_EQUAL_signRuleName = "Old_style_column_alias_via_EQUAL_sign_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Old_style_column_alias_via_EQUAL_signVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Procedure_body_not_enclosed_with_BEGIN_END",
    Constants.ResourceBaseName,
    Procedure_body_not_enclosed_with_BEGIN_ENDRuleName,
    Procedure_body_not_enclosed_with_BEGIN_ENDProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Procedure_body_not_enclosed_with_BEGIN_ENDRule : CarnageSqlCodeAnalysisRule
    {
        private const string Procedure_body_not_enclosed_with_BEGIN_ENDProblemDescription = "Procedure_body_not_enclosed_with_BEGIN_END_ProblemDescription";
        private const string Procedure_body_not_enclosed_with_BEGIN_ENDRuleName = "Procedure_body_not_enclosed_with_BEGIN_END_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Procedure_body_not_enclosed_with_BEGIN_ENDVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.SQL_92_style_cursor_declaration_is_used",
    Constants.ResourceBaseName,
    SQL_92_style_cursor_declaration_is_usedRuleName,
    SQL_92_style_cursor_declaration_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class SQL_92_style_cursor_declaration_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string SQL_92_style_cursor_declaration_is_usedProblemDescription = "SQL_92_style_cursor_declaration_is_used_ProblemDescription";
        private const string SQL_92_style_cursor_declaration_is_usedRuleName = "SQL_92_style_cursor_declaration_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new SQL_92_style_cursor_declaration_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.IF_or_ELSE_without_BEGIN_END_block",
    Constants.ResourceBaseName,
    IF_or_ELSE_without_BEGIN_END_blockRuleName,
    IF_or_ELSE_without_BEGIN_END_blockProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class IF_or_ELSE_without_BEGIN_END_blockRule : CarnageSqlCodeAnalysisRule
    {
        private const string IF_or_ELSE_without_BEGIN_END_blockProblemDescription = "IF_or_ELSE_without_BEGIN_END_block_ProblemDescription";
        private const string IF_or_ELSE_without_BEGIN_END_blockRuleName = "IF_or_ELSE_without_BEGIN_END_block_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new IF_or_ELSE_without_BEGIN_END_blockVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Old_style_TOP_clause_is_used",
    Constants.ResourceBaseName,
    Old_style_TOP_clause_is_usedRuleName,
    Old_style_TOP_clause_is_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Old_style_TOP_clause_is_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Old_style_TOP_clause_is_usedProblemDescription = "Old_style_TOP_clause_is_used_ProblemDescription";
        private const string Old_style_TOP_clause_is_usedRuleName = "Old_style_TOP_clause_is_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Old_style_TOP_clause_is_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Cursor_name_is_reused",
    Constants.ResourceBaseName,
    Cursor_name_is_reusedRuleName,
    Cursor_name_is_reusedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Cursor_name_is_reusedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Cursor_name_is_reusedProblemDescription = "Cursor_name_is_reused_ProblemDescription";
        private const string Cursor_name_is_reusedRuleName = "Cursor_name_is_reused_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Cursor_name_is_reusedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Non_named_parameter_style_used",
    Constants.ResourceBaseName,
    Non_named_parameter_style_usedRuleName,
    Non_named_parameter_style_usedProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Non_named_parameter_style_usedRule : CarnageSqlCodeAnalysisRule
    {
        private const string Non_named_parameter_style_usedProblemDescription = "Non_named_parameter_style_used_ProblemDescription";
        private const string Non_named_parameter_style_usedRuleName = "Non_named_parameter_style_used_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Non_named_parameter_style_usedVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Avoid_using_GOTO_to_improve_readability",
    Constants.ResourceBaseName,
    Avoid_using_GOTO_to_improve_readabilityRuleName,
    Avoid_using_GOTO_to_improve_readabilityProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Avoid_using_GOTO_to_improve_readabilityRule : CarnageSqlCodeAnalysisRule
    {
        private const string Avoid_using_GOTO_to_improve_readabilityProblemDescription = "Avoid_using_GOTO_to_improve_readability_ProblemDescription";
        private const string Avoid_using_GOTO_to_improve_readabilityRuleName = "Avoid_using_GOTO_to_improve_readability_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Avoid_using_GOTO_to_improve_readabilityVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Use_alias_for_all_table_sources",
    Constants.ResourceBaseName,
    Use_alias_for_all_table_sourcesRuleName,
    Use_alias_for_all_table_sourcesProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Use_alias_for_all_table_sourcesRule : CarnageSqlCodeAnalysisRule
    {
        private const string Use_alias_for_all_table_sourcesProblemDescription = "Use_alias_for_all_table_sources_ProblemDescription";
        private const string Use_alias_for_all_table_sourcesRuleName = "Use_alias_for_all_table_sources_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Use_alias_for_all_table_sourcesVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Consider_using_table_variable_instead_of_temporary_table",
    Constants.ResourceBaseName,
    Consider_using_table_variable_instead_of_temporary_tableRuleName,
    Consider_using_table_variable_instead_of_temporary_tableProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Consider_using_table_variable_instead_of_temporary_tableRule : CarnageSqlCodeAnalysisRule
    {
        private const string Consider_using_table_variable_instead_of_temporary_tableProblemDescription = "Consider_using_table_variable_instead_of_temporary_table_ProblemDescription";
        private const string Consider_using_table_variable_instead_of_temporary_tableRuleName = "Consider_using_table_variable_instead_of_temporary_table_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Consider_using_table_variable_instead_of_temporary_tableVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}

namespace Carnage.Core.Rules.Data.Rules
{
    using System.Collections.Generic;
    using Carnage.Core.Rules.Data.Attributes;
    using Carnage.Core.Rules.Data.Visitors;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    /* If the name is Funky, please change it in RuleIdentities NOT HERE */
    [LocalizedExportCodeAnalysisRule("RuleIdentities.Consider_using_temporary_table_instead_of_table_variable",
    Constants.ResourceBaseName,
    Consider_using_temporary_table_instead_of_table_variableRuleName,
    Consider_using_temporary_table_instead_of_table_variableProblemDescription,
    Category = Constants.Design,
    RuleScope = SqlRuleScope.Element)]
    internal sealed class Consider_using_temporary_table_instead_of_table_variableRule : CarnageSqlCodeAnalysisRule
    {
        private const string Consider_using_temporary_table_instead_of_table_variableProblemDescription = "Consider_using_temporary_table_instead_of_table_variable_ProblemDescription";
        private const string Consider_using_temporary_table_instead_of_table_variableRuleName = "Consider_using_temporary_table_instead_of_table_variable_RuleName";

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor, string elementName, TSqlObject modelElement)
        {
            var visitor = new Consider_using_temporary_table_instead_of_table_variableVisitor();
            fragment.Accept(visitor);
            return this.CreateProblemsAsWarning(ruleDescriptor, elementName, modelElement, visitor.ErroneousFragments);
        }
    }
}


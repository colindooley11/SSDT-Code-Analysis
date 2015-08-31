

 
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class AvoidWaitForDelayRuleIdVisitor : TSqlFragmentVisitor
    {
        public AvoidWaitForDelayRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DoNotUseSelectAllRuleIdVisitor : TSqlFragmentVisitor
    {
        public DoNotUseSelectAllRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class KeywordsUppercaseRuleIdVisitor : TSqlFragmentVisitor
    {
        public KeywordsUppercaseRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class TableAliasRuleIdVisitor : TSqlFragmentVisitor
    {
        public TableAliasRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ColumnNamesMustBeSpecifiedRuleIdVisitor : TSqlFragmentVisitor
    {
        public ColumnNamesMustBeSpecifiedRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DoNotUseNumbersInOrderByRuleIdVisitor : TSqlFragmentVisitor
    {
        public DoNotUseNumbersInOrderByRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SchemaPrefixRuleIdVisitor : TSqlFragmentVisitor
    {
        public SchemaPrefixRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class JoinsMustNotBeInWhereClauseRuleIdVisitor : TSqlFragmentVisitor
    {
        public JoinsMustNotBeInWhereClauseRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class AvoidUsingSetOptionsRuleIdVisitor : TSqlFragmentVisitor
    {
        public AvoidUsingSetOptionsRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ProhibitedTypesRuleIdVisitor : TSqlFragmentVisitor
    {
        public ProhibitedTypesRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class AvoidUsingGlobalVariableForIdentityRuleIdVisitor : TSqlFragmentVisitor
    {
        public AvoidUsingGlobalVariableForIdentityRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class UsingIndexedViewsRuleIdVisitor : TSqlFragmentVisitor
    {
        public UsingIndexedViewsRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class FullTextIndexRuleIdVisitor : TSqlFragmentVisitor
    {
        public FullTextIndexRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class UsingIndexedViewsIdVisitor : TSqlFragmentVisitor
    {
        public UsingIndexedViewsIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class PrimaryKeyRuleIdVisitor : TSqlFragmentVisitor
    {
        public PrimaryKeyRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CollationRuleIdVisitor : TSqlFragmentVisitor
    {
        public CollationRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DynamicSqlRuleIdVisitor : TSqlFragmentVisitor
    {
        public DynamicSqlRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class BalancedNumberOfSetOptionsNoCountRuleIdVisitor : TSqlFragmentVisitor
    {
        public BalancedNumberOfSetOptionsNoCountRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ReturnStatementPresentRuleIdVisitor : TSqlFragmentVisitor
    {
        public ReturnStatementPresentRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DoNotUseHintsRuleIdVisitor : TSqlFragmentVisitor
    {
        public DoNotUseHintsRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DdlRuleIdVisitor : TSqlFragmentVisitor
    {
        public DdlRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class HeaderRuleIdVisitor : TSqlFragmentVisitor
    {
        public HeaderRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DataTypesLowercaseRuleIdVisitor : TSqlFragmentVisitor
    {
        public DataTypesLowercaseRuleIdVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Index_Type_Is_Not_SpecifiedVisitor : TSqlFragmentVisitor
    {
        public Index_Type_Is_Not_SpecifiedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ORDER_BY_clause_with_constantsVisitor : TSqlFragmentVisitor
    {
        public ORDER_BY_clause_with_constantsVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SELECT_in_triggerVisitor : TSqlFragmentVisitor
    {
        public SELECT_in_triggerVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class INSERT_without_column_listVisitor : TSqlFragmentVisitor
    {
        public INSERT_without_column_listVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Asterisk_in_select_listVisitor : TSqlFragmentVisitor
    {
        public Asterisk_in_select_listVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class TOP_without_ORDER_BYVisitor : TSqlFragmentVisitor
    {
        public TOP_without_ORDER_BYVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Declaring_var_type_variables_without_lengthVisitor : TSqlFragmentVisitor
    {
        public Declaring_var_type_variables_without_lengthVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CAST_CONVERT_to_var_types_without_lengthVisitor : TSqlFragmentVisitor
    {
        public CAST_CONVERT_to_var_types_without_lengthVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Avoid_var_types_of_length_1_or_2Visitor : TSqlFragmentVisitor
    {
        public Avoid_var_types_of_length_1_or_2Visitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Usage_of_identityVisitor : TSqlFragmentVisitor
    {
        public Usage_of_identityVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class NULL_comparison_or_addition_substringVisitor : TSqlFragmentVisitor
    {
        public NULL_comparison_or_addition_substringVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CASE_without_ELSEVisitor : TSqlFragmentVisitor
    {
        public CASE_without_ELSEVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class EXECUTE_string_is_usedVisitor : TSqlFragmentVisitor
    {
        public EXECUTE_string_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementVisitor : TSqlFragmentVisitor
    {
        public NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statementVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedVisitor : TSqlFragmentVisitor
    {
        public Scope_of_cursor_LOCAL_GLOBAL_is_not_specifiedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Return_without_result_codeVisitor : TSqlFragmentVisitor
    {
        public Return_without_result_codeVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DELETE_statement_without_WHERE_clauseVisitor : TSqlFragmentVisitor
    {
        public DELETE_statement_without_WHERE_clauseVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class UPDATE_statement_without_WHERE_clauseVisitor : TSqlFragmentVisitor
    {
        public UPDATE_statement_without_WHERE_clauseVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Incompatible_variable_type_for_procedure_callVisitor : TSqlFragmentVisitor
    {
        public Incompatible_variable_type_for_procedure_callVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Incompatible_literal_type_for_procedure_callVisitor : TSqlFragmentVisitor
    {
        public Incompatible_literal_type_for_procedure_callVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Non_scalar_subquery_in_place_of_a_scalarVisitor : TSqlFragmentVisitor
    {
        public Non_scalar_subquery_in_place_of_a_scalarVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Extra_parameter_passedVisitor : TSqlFragmentVisitor
    {
        public Extra_parameter_passedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Unnamed_call_after_named_callVisitor : TSqlFragmentVisitor
    {
        public Unnamed_call_after_named_callVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Required_parameter_is_not_passedVisitor : TSqlFragmentVisitor
    {
        public Required_parameter_is_not_passedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Call_parameter_declared_as_outputVisitor : TSqlFragmentVisitor
    {
        public Call_parameter_declared_as_outputVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Call_parameter_is_not_declared_as_outputVisitor : TSqlFragmentVisitor
    {
        public Call_parameter_is_not_declared_as_outputVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Call_has_more_parameters_than_requiredVisitor : TSqlFragmentVisitor
    {
        public Call_has_more_parameters_than_requiredVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class OPEN_of_undefined_cursorVisitor : TSqlFragmentVisitor
    {
        public OPEN_of_undefined_cursorVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class FETCH_from_undefined_cursorVisitor : TSqlFragmentVisitor
    {
        public FETCH_from_undefined_cursorVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CLOSE_of_undefined_cursorVisitor : TSqlFragmentVisitor
    {
        public CLOSE_of_undefined_cursorVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DEALLOCATE_of_undefined_cursorVisitor : TSqlFragmentVisitor
    {
        public DEALLOCATE_of_undefined_cursorVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsVisitor : TSqlFragmentVisitor
    {
        public Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columnsVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Incorrect_number_of_fetch_variablesVisitor : TSqlFragmentVisitor
    {
        public Incorrect_number_of_fetch_variablesVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Reference_to_procedure_in_other_databaseVisitor : TSqlFragmentVisitor
    {
        public Reference_to_procedure_in_other_databaseVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Hardcoded_current_database_name_in_procedure_callVisitor : TSqlFragmentVisitor
    {
        public Hardcoded_current_database_name_in_procedure_callVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Missing_parameters_name_in_procedure_callVisitor : TSqlFragmentVisitor
    {
        public Missing_parameters_name_in_procedure_callVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONVisitor : TSqlFragmentVisitor
    {
        public BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTIONVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONVisitor : TSqlFragmentVisitor
    {
        public ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTIONVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Closing_of_unopened_cursorVisitor : TSqlFragmentVisitor
    {
        public Closing_of_unopened_cursorVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Fetch_from_unopened_cursorVisitor : TSqlFragmentVisitor
    {
        public Fetch_from_unopened_cursorVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableVisitor : TSqlFragmentVisitor
    {
        public Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatableVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Stored_procedure_name_starts_with_sp_Visitor : TSqlFragmentVisitor
    {
        public Stored_procedure_name_starts_with_sp_Visitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Executing_stored_procedure_without_getting_resultVisitor : TSqlFragmentVisitor
    {
        public Executing_stored_procedure_without_getting_resultVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Reference_to_function_in_other_databaseVisitor : TSqlFragmentVisitor
    {
        public Reference_to_function_in_other_databaseVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Reference_to_table_or_view_in_other_databaseVisitor : TSqlFragmentVisitor
    {
        public Reference_to_table_or_view_in_other_databaseVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Adding_NOT_NULL_column_without_default_valueVisitor : TSqlFragmentVisitor
    {
        public Adding_NOT_NULL_column_without_default_valueVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Avoid_using_ISNUMERIC___functionVisitor : TSqlFragmentVisitor
    {
        public Avoid_using_ISNUMERIC___functionVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CGTIMETimed_outVisitor : TSqlFragmentVisitor
    {
        public CGTIMETimed_outVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CGUNPUnparsed_SQLVisitor : TSqlFragmentVisitor
    {
        public CGUNPUnparsed_SQLVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Table_var_is_declared_but_never_usedVisitor : TSqlFragmentVisitor
    {
        public Table_var_is_declared_but_never_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Temp_table_is_declared_but_never_usedVisitor : TSqlFragmentVisitor
    {
        public Temp_table_is_declared_but_never_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Unqualified_column_nameVisitor : TSqlFragmentVisitor
    {
        public Unqualified_column_nameVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Usage_of_sp_executesql__only_in_proc_triggerVisitor : TSqlFragmentVisitor
    {
        public Usage_of_sp_executesql__only_in_proc_triggerVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Variable_is_declared_but_never_usedVisitor : TSqlFragmentVisitor
    {
        public Variable_is_declared_but_never_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Parameter_is_declared_but_never_usedVisitor : TSqlFragmentVisitor
    {
        public Parameter_is_declared_but_never_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Schema_name_for_procedure_is_not_specifiedVisitor : TSqlFragmentVisitor
    {
        public Schema_name_for_procedure_is_not_specifiedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Schema_name_for_table_or_view_is_not_specifiedVisitor : TSqlFragmentVisitor
    {
        public Schema_name_for_table_or_view_is_not_specifiedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Creation_of_table_by_SELECT_INTO_statementVisitor : TSqlFragmentVisitor
    {
        public Creation_of_table_by_SELECT_INTO_statementVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class INDEX_HINT_is_usedVisitor : TSqlFragmentVisitor
    {
        public INDEX_HINT_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class JOIN_HINT_is_usedVisitor : TSqlFragmentVisitor
    {
        public JOIN_HINT_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class TABLE_HINT_is_usedVisitor : TSqlFragmentVisitor
    {
        public TABLE_HINT_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class QUERY_HINT_is_usedVisitor : TSqlFragmentVisitor
    {
        public QUERY_HINT_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SET_NOCOUNT_OFF_is_usedVisitor : TSqlFragmentVisitor
    {
        public SET_NOCOUNT_OFF_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class No_SET_NOCOUNT_ON_before_DMLVisitor : TSqlFragmentVisitor
    {
        public No_SET_NOCOUNT_ON_before_DMLVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Interleaving_DDL_and_DML_in_stored_proc_triggerVisitor : TSqlFragmentVisitor
    {
        public Interleaving_DDL_and_DML_in_stored_proc_triggerVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class PRINT_statement_is_used_in_triggerVisitor : TSqlFragmentVisitor
    {
        public PRINT_statement_is_used_in_triggerVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerVisitor : TSqlFragmentVisitor
    {
        public Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_triggerVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Incorrect_usage_of_COUNT__Visitor : TSqlFragmentVisitor
    {
        public Incorrect_usage_of_COUNT__Visitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SET_FORCEPLAN_usedVisitor : TSqlFragmentVisitor
    {
        public SET_FORCEPLAN_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyVisitor : TSqlFragmentVisitor
    {
        public No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_onlyVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Cursor_is_opened_but_is_not_deallocatedVisitor : TSqlFragmentVisitor
    {
        public Cursor_is_opened_but_is_not_deallocatedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Incorrect_usage_of_const_UDFVisitor : TSqlFragmentVisitor
    {
        public Incorrect_usage_of_const_UDFVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyVisitor : TSqlFragmentVisitor
    {
        public No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonlyVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_Visitor : TSqlFragmentVisitor
    {
        public Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_Visitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Script_should_end_with_GOVisitor : TSqlFragmentVisitor
    {
        public Script_should_end_with_GOVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Script_should_end_with_empty_lineVisitor : TSqlFragmentVisitor
    {
        public Script_should_end_with_empty_lineVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class There_should_be_no_USE_statement_in_batchVisitor : TSqlFragmentVisitor
    {
        public There_should_be_no_USE_statement_in_batchVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Old_style_join_is_used__from_table1_table2Visitor : TSqlFragmentVisitor
    {
        public Old_style_join_is_used__from_table1_table2Visitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Old_style_column_alias_via_EQUAL_signVisitor : TSqlFragmentVisitor
    {
        public Old_style_column_alias_via_EQUAL_signVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Procedure_body_not_enclosed_with_BEGIN_ENDVisitor : TSqlFragmentVisitor
    {
        public Procedure_body_not_enclosed_with_BEGIN_ENDVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SQL_92_style_cursor_declaration_is_usedVisitor : TSqlFragmentVisitor
    {
        public SQL_92_style_cursor_declaration_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class IF_or_ELSE_without_BEGIN_END_blockVisitor : TSqlFragmentVisitor
    {
        public IF_or_ELSE_without_BEGIN_END_blockVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Old_style_TOP_clause_is_usedVisitor : TSqlFragmentVisitor
    {
        public Old_style_TOP_clause_is_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Cursor_name_is_reusedVisitor : TSqlFragmentVisitor
    {
        public Cursor_name_is_reusedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Non_named_parameter_style_usedVisitor : TSqlFragmentVisitor
    {
        public Non_named_parameter_style_usedVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Avoid_using_GOTO_to_improve_readabilityVisitor : TSqlFragmentVisitor
    {
        public Avoid_using_GOTO_to_improve_readabilityVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Use_alias_for_all_table_sourcesVisitor : TSqlFragmentVisitor
    {
        public Use_alias_for_all_table_sourcesVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Consider_using_table_variable_instead_of_temporary_tableVisitor : TSqlFragmentVisitor
    {
        public Consider_using_table_variable_instead_of_temporary_tableVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class Consider_using_temporary_table_instead_of_table_variableVisitor : TSqlFragmentVisitor
    {
        public Consider_using_temporary_table_instead_of_table_variableVisitor()
        {
            this.ErroneousFragments = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> ErroneousFragments { get; private set; }

        /* REPLACE TsqlScript with the appropriate Fragment type you need to visit */
        public override void ExplicitVisit(TSqlScript node)
        {
            this.ErroneousFragments.Add(node);
        }
    }
}

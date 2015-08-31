namespace Asos.Core.Rules.Data.CodeGen
{
    /// <summary>
    /// The Rule ID should resemble a fully-qualified class name. In the Visual Studio UI
    /// rules are grouped by "Namespace + Category", and each rule is shown using "Short ID: DisplayName".
    /// </summary>
    public class RuleIdentities
    {
        public const string AvoidWaitForDelayRuleId = "Asos.Core.Data.Rules.AR1000";
        public const string DoNotUseSelectAllRuleId = "Asos.Core.Data.Rules.AR1001";
        public const string KeywordsUppercaseRuleId = "Asos.Core.Data.Rules.AR1002";
        public const string TableAliasRuleId = "Asos.Core.Data.Rules.AR1003";
        public const string ColumnNamesMustBeSpecifiedRuleId = "Asos.Core.Data.Rules.AR1004";
        public const string DoNotUseNumbersInOrderByRuleId = "Asos.Core.Data.Rules.AR1005";
        public const string SchemaPrefixRuleId = "Asos.Core.Data.Rules.AR1006";
        public const string JoinsMustNotBeInWhereClauseRuleId = "Asos.Core.Data.Rules.AR1007";
        public const string AvoidUsingSetOptionsRuleId = "Asos.Core.Data.Rules.AR1008";
        public const string ProhibitedTypesRuleId = "Asos.Core.Data.Rules.AR1009";
        public const string AvoidUsingGlobalVariableForIdentityRuleId = "Asos.Core.Data.Rules.AR1010";
        public const string UsingIndexedViewsRuleId = "Asos.Core.Data.Rules.AR1011";
        public const string FullTextIndexRuleId = "Asos.Core.Data.Rules.AR1012";
        public const string UsingIndexedViewsId = "Asos.Core.Data.Rules.AR1013";
        public const string PrimaryKeyRuleId = "Asos.Core.Data.Rules.AR1014";
        public const string CollationRuleId = "Asos.Core.Data.Rules.AR1015";
        public const string DynamicSqlRuleId = "Asos.Core.Data.Rules.AR1016";
        public const string BalancedNumberOfSetOptionsNoCountRuleId = "Asos.Core.Data.Rules.AR1017";
        public const string ReturnStatementPresentRuleId = "Asos.Core.Data.Rules.AR1018";
        public const string DoNotUseHintsRuleId = "Asos.Core.Data.Rules.AR1019";
        public const string DdlRuleId = "Asos.Core.Data.Rules.AR1020";
        public const string HeaderRuleId = "Asos.Core.Data.Rules.AR1021";
        public const string DataTypesLowercaseRuleId = "Asos.Core.Data.Rules.AR1022";

        // SQL Code Guard additions
        public const string Index_Type_Is_Not_Specified = "Asos.Core.Data.Rules.AR1000";
        public const string ORDER_BY_clause_with_constants = "Asos.Core.Data.Rules.AR1000";
        public const string SELECT_in_trigger = "Asos.Core.Data.Rules.AR1000";
        public const string INSERT_without_column_list = "Asos.Core.Data.Rules.AR1000";
        public const string Asterisk_in_select_list = "Asos.Core.Data.Rules.AR1000";
        public const string TOP_without_ORDER_BY = "Asos.Core.Data.Rules.AR1000";
        public const string Declaring_var_type_variables_without_length = "Asos.Core.Data.Rules.AR1000";
        public const string CAST_CONVERT_to_var_types_without_length = "Asos.Core.Data.Rules.AR10000";
        public const string Avoid_var_types_of_length_1_or_2 = "Asos.Core.Data.Rules.AR10000";
        public const string Usage_of_identity = "Asos.Core.Data.Rules.AR10000";
        public const string NULL_comparison_or_addition_substring = "Asos.Core.Data.Rules.AR10000";
        public const string CASE_without_ELSE = "Asos.Core.Data.Rules.AR10000";
        public const string EXECUTE_string_is_used = "Asos.Core.Data.Rules.AR10000";
        public const string NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statement = "Asos.Core.Data.Rules.AR10000";
        public const string Scope_of_cursor_LOCAL_GLOBAL_is_not_specified = "Asos.Core.Data.Rules.AR10000";
        public const string Return_without_result_code = "Asos.Core.Data.Rules.AR10000";
        public const string DELETE_statement_without_WHERE_clause = "Asos.Core.Data.Rules.AR10000";
        public const string UPDATE_statement_without_WHERE_clause = "Asos.Core.Data.Rules.AR10000";
        public const string Incompatible_variable_type_for_procedure_call = "Asos.Core.Data.Rules.AR10000";
        public const string Incompatible_literal_type_for_procedure_call = "Asos.Core.Data.Rules.AR10000";
        public const string Non_scalar_subquery_in_place_of_a_scalar = "Asos.Core.Data.Rules.AR10000";
        public const string Extra_parameter_passed = "Asos.Core.Data.Rules.AR10000";
        public const string Unnamed_call_after_named_call = "Asos.Core.Data.Rules.AR10000";
        public const string Required_parameter_is_not_passed = "Asos.Core.Data.Rules.AR1000";
        public const string Call_parameter_declared_as_output = "Asos.Core.Data.Rules.AR1000";
        public const string Call_parameter_is_not_declared_as_output = "Asos.Core.Data.Rules.AR1000";
        public const string Call_has_more_parameters_than_required = "Asos.Core.Data.Rules.AR1000";
        public const string OPEN_of_undefined_cursor = "Asos.Core.Data.Rules.AR1000";
        public const string FETCH_from_undefined_cursor = "Asos.Core.Data.Rules.AR1000";
        public const string CLOSE_of_undefined_cursor = "Asos.Core.Data.Rules.AR1000";
        public const string DEALLOCATE_of_undefined_cursor = "Asos.Core.Data.Rules.AR1000";
        public const string Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columns = "Asos.Core.Data.Rules.AR1000";
        public const string Incorrect_number_of_fetch_variables = "Asos.Core.Data.Rules.AR1000";
        public const string Reference_to_procedure_in_other_database = "Asos.Core.Data.Rules.AR1000";
        public const string Hardcoded_current_database_name_in_procedure_call = "Asos.Core.Data.Rules.AR1000";
        public const string Missing_parameters_name_in_procedure_call = "Asos.Core.Data.Rules.AR1000";
        public const string BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTION = "Asos.Core.Data.Rules.AR1000";
        public const string ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTION = "Asos.Core.Data.Rules.AR1000";
        public const string Closing_of_unopened_cursor = "Asos.Core.Data.Rules.AR1000";
        public const string Fetch_from_unopened_cursor = "Asos.Core.Data.Rules.AR1000";
        public const string Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatable = "Asos.Core.Data.Rules.AR1000";
        public const string Stored_procedure_name_starts_with_sp_ = "Asos.Core.Data.Rules.AR1000";
        public const string Executing_stored_procedure_without_getting_result = "Asos.Core.Data.Rules.AR1000";
        public const string Reference_to_function_in_other_database = "Asos.Core.Data.Rules.AR1000";
        public const string Reference_to_table_or_view_in_other_database = "Asos.Core.Data.Rules.AR1000";
        public const string Adding_NOT_NULL_column_without_default_value = "Asos.Core.Data.Rules.AR1000";
        public const string Avoid_using_ISNUMERIC___function = "Asos.Core.Data.Rules.AR1000";
        public const string CGTIMETimed_out = "Asos.Core.Data.Rules.AR1000";
        public const string CGUNPUnparsed_SQL = "Asos.Core.Data.Rules.AR1000";
        public const string Table_var_is_declared_but_never_used = "Asos.Core.Data.Rules.AR1000";
        public const string Temp_table_is_declared_but_never_used = "Asos.Core.Data.Rules.AR1000";
        public const string Unqualified_column_name = "Asos.Core.Data.Rules.AR1000";
        public const string Usage_of_sp_executesql__only_in_proc_trigger = "Asos.Core.Data.Rules.AR1000";
        public const string Variable_is_declared_but_never_used = "Asos.Core.Data.Rules.AR1000";
        public const string Parameter_is_declared_but_never_used = "Asos.Core.Data.Rules.AR1000";
        public const string Schema_name_for_procedure_is_not_specified = "Asos.Core.Data.Rules.AR1000";
        public const string Schema_name_for_table_or_view_is_not_specified = "Asos.Core.Data.Rules.AR1000";
        public const string Creation_of_table_by_SELECT_INTO_statement = "Asos.Core.Data.Rules.AR1000";
        public const string INDEX_HINT_is_used = "Asos.Core.Data.Rules.AR1000";
        public const string JOIN_HINT_is_used = "Asos.Core.Data.Rules.AR1000";
        public const string TABLE_HINT_is_used = "Asos.Core.Data.Rules.AR1000";
        public const string QUERY_HINT_is_used = "Asos.Core.Data.Rules.AR1000";
        public const string SET_NOCOUNT_OFF_is_used = "Asos.Core.Data.Rules.AR1000";
        public const string No_SET_NOCOUNT_ON_before_DML = "Asos.Core.Data.Rules.AR1000";
        public const string Interleaving_DDL_and_DML_in_stored_proc_trigger = "Asos.Core.Data.Rules.AR1000";
        public const string PRINT_statement_is_used_in_trigger = "Asos.Core.Data.Rules.AR1000";
        public const string Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_trigger = "Asos.Core.Data.Rules.AR1000";
        public const string Incorrect_usage_of_COUNT__ = "Asos.Core.Data.Rules.AR1000";
        public const string SET_FORCEPLAN_used = "Asos.Core.Data.Rules.AR1000";
        public const string No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_only = "Asos.Core.Data.Rules.AR1000";
        public const string Cursor_is_opened_but_is_not_deallocated = "Asos.Core.Data.Rules.AR1000";
        public const string Incorrect_usage_of_const_UDF = "Asos.Core.Data.Rules.AR1000";
        public const string No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonly = "Asos.Core.Data.Rules.AR1000";
        public const string Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_ = "Asos.Core.Data.Rules.AR1000";
        public const string Script_should_end_with_GO = "Asos.Core.Data.Rules.AR1000";
        public const string Script_should_end_with_empty_line = "Asos.Core.Data.Rules.AR1000";
        public const string There_should_be_no_USE_statement_in_batch = "Asos.Core.Data.Rules.AR1000";
        public const string Old_style_join_is_used__from_table1_table2 = "Asos.Core.Data.Rules.AR1000";
        public const string Old_style_column_alias_via_EQUAL_sign = "Asos.Core.Data.Rules.AR1000";
        public const string Procedure_body_not_enclosed_with_BEGIN_END = "Asos.Core.Data.Rules.AR1000";
        public const string SQL_92_style_cursor_declaration_is_used = "Asos.Core.Data.Rules.AR1000";
        public const string IF_or_ELSE_without_BEGIN_END_block = "Asos.Core.Data.Rules.AR1000";
        public const string Old_style_TOP_clause_is_used = "Asos.Core.Data.Rules.AR1000";
        public const string Cursor_name_is_reused = "Asos.Core.Data.Rules.AR1000";
        public const string Non_named_parameter_style_used = "Asos.Core.Data.Rules.AR1000";
        public const string Avoid_using_GOTO_to_improve_readability = "Asos.Core.Data.Rules.AR1000";
        public const string Use_alias_for_all_table_sources = "Asos.Core.Data.Rules.AR1000";
        public const string Consider_using_table_variable_instead_of_temporary_table = "Asos.Core.Data.Rules.AR1000";
        public const string Consider_using_temporary_table_instead_of_table_variable = "Asos.Core.Data.Rules.AR1000";
    }
}
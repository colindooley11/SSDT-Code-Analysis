namespace Carnage.Core.Rules.Data
{
    /// <summary>
    /// The Rule ID should resemble a fully-qualified class name. In the Visual Studio UI
    /// rules are grouped by "Namespace + Category", and each rule is shown using "Short ID: DisplayName".
    /// </summary>
    public class RuleIdentities
    {
        public const string AvoidWaitForDelayRuleId = "Carnage.Core.Data.Rules.C1000";
        public const string DoNotUseSelectAllRuleId = "Carnage.Core.Data.Rules.C1001";
        public const string KeywordsUppercaseRuleId = "Carnage.Core.Data.Rules.C1002";
        public const string TableAliasRuleId = "Carnage.Core.Data.Rules.C1003";
        public const string ColumnNamesMustBeSpecifiedRuleId = "Carnage.Core.Data.Rules.C1004";
        public const string DoNotUseNumbersInOrderByRuleId = "Carnage.Core.Data.Rules.C1005";
        public const string SchemaPrefixRuleId = "Carnage.Core.Data.Rules.C1006";
        public const string JoinsMustNotBeInWhereClauseRuleId = "Carnage.Core.Data.Rules.C1007";
        public const string AvoidUsingSetOptionsRuleId = "Carnage.Core.Data.Rules.C1008";
        public const string ProhibitedTypesRuleId = "Carnage.Core.Data.Rules.C1009";
        public const string AvoidUsingGlobalVariableForIdentityRuleId = "Carnage.Core.Data.Rules.C1010";
        public const string UsingIndexedViewsRuleId = "Carnage.Core.Data.Rules.C1011";
        public const string FullTextIndexRuleId = "Carnage.Core.Data.Rules.C1012";
        public const string UsingIndexedViewsId = "Carnage.Core.Data.Rules.C1013";
        public const string PrimaryKeyRuleId = "Carnage.Core.Data.Rules.C1014";
        public const string CollationRuleId = "Carnage.Core.Data.Rules.C1015";
        public const string DynamicSqlRuleId = "Carnage.Core.Data.Rules.C1016";
        public const string BalancedNumberOfSetOptionsNoCountRuleId = "Carnage.Core.Data.Rules.C1017";
        public const string ReturnStatementPresentRuleId = "Carnage.Core.Data.Rules.C1018";
        public const string DoNotUseHintsRuleId = "Carnage.Core.Data.Rules.C1019";
        public const string DdlRuleId = "Carnage.Core.Data.Rules.C1020";
        public const string HeaderRuleId = "Carnage.Core.Data.Rules.C1021";
        public const string DataTypesLowercaseRuleId = "Carnage.Core.Data.Rules.C1022";

        // SQL Code Guard additions - change names here to drive code genned classes.
        public const string Index_Type_Is_Not_Specified = "Carnage.Core.Data.Rules.C1000";
        public const string ORDER_BY_clause_with_constants = "Carnage.Core.Data.Rules.C1000";
        public const string SELECT_in_trigger = "Carnage.Core.Data.Rules.C1000";
        public const string INSERT_without_column_list = "Carnage.Core.Data.Rules.C1000";
        public const string Asterisk_in_select_list = "Carnage.Core.Data.Rules.C1000";
        public const string TOP_without_ORDER_BY = "Carnage.Core.Data.Rules.C1000";
        public const string Declaring_var_type_variables_without_length = "Carnage.Core.Data.Rules.C1000";
        public const string CAST_CONVERT_to_var_types_without_length = "Carnage.Core.Data.Rules.C10000";
        public const string Avoid_var_types_of_length_1_or_2 = "Carnage.Core.Data.Rules.C10000";
        public const string Usage_of_identity = "Carnage.Core.Data.Rules.C10000";
        public const string NULL_comparison_or_addition_substring = "Carnage.Core.Data.Rules.C10000";
        public const string CASE_without_ELSE = "Carnage.Core.Data.Rules.C10000";
        public const string EXECUTE_string_is_used = "Carnage.Core.Data.Rules.C10000";
        public const string NOT_NULL_option_is_not_specified_in_CREATE_DECLARE_TABLE_statement = "Carnage.Core.Data.Rules.C10000";
        public const string Scope_of_cursor_LOCAL_GLOBAL_is_not_specified = "Carnage.Core.Data.Rules.C10000";
        public const string Return_without_result_code = "Carnage.Core.Data.Rules.C10000";
        public const string DELETE_statement_without_WHERE_clause = "Carnage.Core.Data.Rules.C10000";
        public const string UPDATE_statement_without_WHERE_clause = "Carnage.Core.Data.Rules.C10000";
        public const string Incompatible_variable_type_for_procedure_call = "Carnage.Core.Data.Rules.C10000";
        public const string Incompatible_literal_type_for_procedure_call = "Carnage.Core.Data.Rules.C10000";
        public const string Non_scalar_subquery_in_place_of_a_scalar = "Carnage.Core.Data.Rules.C10000";
        public const string Extra_parameter_passed = "Carnage.Core.Data.Rules.C10000";
        public const string Unnamed_call_after_named_call = "Carnage.Core.Data.Rules.C10000";
        public const string Required_parameter_is_not_passed = "Carnage.Core.Data.Rules.C1000";
        public const string Call_parameter_declared_as_output = "Carnage.Core.Data.Rules.C1000";
        public const string Call_parameter_is_not_declared_as_output = "Carnage.Core.Data.Rules.C1000";
        public const string Call_has_more_parameters_than_required = "Carnage.Core.Data.Rules.C1000";
        public const string OPEN_of_undefined_cursor = "Carnage.Core.Data.Rules.C1000";
        public const string FETCH_from_undefined_cursor = "Carnage.Core.Data.Rules.C1000";
        public const string CLOSE_of_undefined_cursor = "Carnage.Core.Data.Rules.C1000";
        public const string DEALLOCATE_of_undefined_cursor = "Carnage.Core.Data.Rules.C1000";
        public const string Fetch_from_cursor_with_asterisk_in_select_list_unable_to_check_columns = "Carnage.Core.Data.Rules.C1000";
        public const string Incorrect_number_of_fetch_variables = "Carnage.Core.Data.Rules.C1000";
        public const string Reference_to_procedure_in_other_database = "Carnage.Core.Data.Rules.C1000";
        public const string Hardcoded_current_database_name_in_procedure_call = "Carnage.Core.Data.Rules.C1000";
        public const string Missing_parameters_name_in_procedure_call = "Carnage.Core.Data.Rules.C1000";
        public const string BEGIN_TRANSACTION_without_ROLLBACK_TRANSACTION = "Carnage.Core.Data.Rules.C1000";
        public const string ROLLBACK_TRANSACTION_without_BEGIN_TRANSACTION = "Carnage.Core.Data.Rules.C1000";
        public const string Closing_of_unopened_cursor = "Carnage.Core.Data.Rules.C1000";
        public const string Fetch_from_unopened_cursor = "Carnage.Core.Data.Rules.C1000";
        public const string Update_delete_operation_on_cursor_but_cursor_is_not_declared_as_updatable = "Carnage.Core.Data.Rules.C1000";
        public const string Stored_procedure_name_starts_with_sp_ = "Carnage.Core.Data.Rules.C1000";
        public const string Executing_stored_procedure_without_getting_result = "Carnage.Core.Data.Rules.C1000";
        public const string Reference_to_function_in_other_database = "Carnage.Core.Data.Rules.C1000";
        public const string Reference_to_table_or_view_in_other_database = "Carnage.Core.Data.Rules.C1000";
        public const string Adding_NOT_NULL_column_without_default_value = "Carnage.Core.Data.Rules.C1000";
        public const string Avoid_using_ISNUMERIC___function = "Carnage.Core.Data.Rules.C1000";
        public const string CGTIMETimed_out = "Carnage.Core.Data.Rules.C1000";
        public const string CGUNPUnparsed_SQL = "Carnage.Core.Data.Rules.C1000";
        public const string Table_var_is_declared_but_never_used = "Carnage.Core.Data.Rules.C1000";
        public const string Temp_table_is_declared_but_never_used = "Carnage.Core.Data.Rules.C1000";
        public const string Unqualified_column_name = "Carnage.Core.Data.Rules.C1000";
        public const string Usage_of_sp_executesql__only_in_proc_trigger = "Carnage.Core.Data.Rules.C1000";
        public const string Variable_is_declared_but_never_used = "Carnage.Core.Data.Rules.C1000";
        public const string Parameter_is_declared_but_never_used = "Carnage.Core.Data.Rules.C1000";
        public const string Schema_name_for_procedure_is_not_specified = "Carnage.Core.Data.Rules.C1000";
        public const string Schema_name_for_table_or_view_is_not_specified = "Carnage.Core.Data.Rules.C1000";
        public const string Creation_of_table_by_SELECT_INTO_statement = "Carnage.Core.Data.Rules.C1000";
        public const string INDEX_HINT_is_used = "Carnage.Core.Data.Rules.C1000";
        public const string JOIN_HINT_is_used = "Carnage.Core.Data.Rules.C1000";
        public const string TABLE_HINT_is_used = "Carnage.Core.Data.Rules.C1000";
        public const string QUERY_HINT_is_used = "Carnage.Core.Data.Rules.C1000";
        public const string SET_NOCOUNT_OFF_is_used = "Carnage.Core.Data.Rules.C1000";
        public const string No_SET_NOCOUNT_ON_before_DML = "Carnage.Core.Data.Rules.C1000";
        public const string Interleaving_DDL_and_DML_in_stored_proc_trigger = "Carnage.Core.Data.Rules.C1000";
        public const string PRINT_statement_is_used_in_trigger = "Carnage.Core.Data.Rules.C1000";
        public const string Setting_ANSI_DEFAULTS_ANSI_NULLS_ANSI_PADDING_ANSI_WARNINGS_CONCAT_NULL_YIELDS_NULL_lead_to_procedure_recompilation__only_in_proc_trigger = "Carnage.Core.Data.Rules.C1000";
        public const string Incorrect_usage_of_COUNT__ = "Carnage.Core.Data.Rules.C1000";
        public const string SET_FORCEPLAN_used = "Carnage.Core.Data.Rules.C1000";
        public const string No_FETCH_FIRST_LAST_PRIOR_but_cursor_is_not_declared_as_forward_only = "Carnage.Core.Data.Rules.C1000";
        public const string Cursor_is_opened_but_is_not_deallocated = "Carnage.Core.Data.Rules.C1000";
        public const string Incorrect_usage_of_const_UDF = "Carnage.Core.Data.Rules.C1000";
        public const string No_update_delete_operation_on_cursor_but_the_cursor_is_not_declared_as_readonly = "Carnage.Core.Data.Rules.C1000";
        public const string Consider_using_NOT_EXISTS_instead_of_NOT_IN__subquery_ = "Carnage.Core.Data.Rules.C1000";
        public const string Script_should_end_with_GO = "Carnage.Core.Data.Rules.C1000";
        public const string Script_should_end_with_empty_line = "Carnage.Core.Data.Rules.C1000";
        public const string There_should_be_no_USE_statement_in_batch = "Carnage.Core.Data.Rules.C1000";
        public const string Old_style_join_is_used__from_table1_table2 = "Carnage.Core.Data.Rules.C1000";
        public const string Old_style_column_alias_via_EQUAL_sign = "Carnage.Core.Data.Rules.C1000";
        public const string Procedure_body_not_enclosed_with_BEGIN_END = "Carnage.Core.Data.Rules.C1000";
        public const string SQL_92_style_cursor_declaration_is_used = "Carnage.Core.Data.Rules.C1000";
        public const string IF_or_ELSE_without_BEGIN_END_block = "Carnage.Core.Data.Rules.C1000";
        public const string Old_style_TOP_clause_is_used = "Carnage.Core.Data.Rules.C1000";
        public const string Cursor_name_is_reused = "Carnage.Core.Data.Rules.C1000";
        public const string Non_named_parameter_style_used = "Carnage.Core.Data.Rules.C1000";
        public const string Avoid_using_GOTO_to_improve_readability = "Carnage.Core.Data.Rules.C1000";
        public const string Use_alias_for_all_table_sources = "Carnage.Core.Data.Rules.C1000";
        public const string Consider_using_table_variable_instead_of_temporary_table = "Carnage.Core.Data.Rules.C1000";
        public const string Consider_using_temporary_table_instead_of_table_variable = "Carnage.Core.Data.Rules.C1000";
    }
}
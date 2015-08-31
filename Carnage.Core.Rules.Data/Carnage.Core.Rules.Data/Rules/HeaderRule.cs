namespace Carnage.Core.Rules.Data.Rules
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Carnage.Core.Rules.Data.Attributes;
    using Microsoft.SqlServer.Dac.CodeAnalysis;
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    [LocalizedExportCodeAnalysisRule(RuleIdentities.HeaderRuleId,
        Constants.ResourceBaseName,
        HeaderRuleName,
        HeaderProblemDescription,
        Category = Constants.General,
        RuleScope = SqlRuleScope.Element)]
    internal sealed class HeaderRule : CarnageSqlCodeAnalysisRule
    {
        private const string HeaderProblemDescription = "Header_ProblemDescription";
        private const string HeaderRuleName = "Header_RuleName";
        private readonly List<string> KnownHeaderItems;

        public HeaderRule()
        {
            this.KnownHeaderItems = new List<string>
                {
                    "*System",
                    "*Procedure Name",
                    "*Created By",
                    "*Create Date",
                    "*Params",
                    "*Output",
                    "*Called By",
                    "*Calls",
                    "*Description "
                };
        }

        protected override IList<SqlRuleProblem> ElicitProblems(TSqlFragment fragment, RuleDescriptor ruleDescriptor,string elementName, TSqlObject modelElement)
        {

            var sb = new StringBuilder();
            foreach (var scriptTokenStreamFragment in fragment.ScriptTokenStream)
            {
                sb.Append(scriptTokenStreamFragment.Text);
            }

            var fullScript = sb.ToString();
            var isHeaderPresent = true; 
            foreach (var knownHeaderItem in this.KnownHeaderItems)
            {
                if (fullScript.IndexOf(knownHeaderItem, StringComparison.OrdinalIgnoreCase) == -1)
                {
                    isHeaderPresent = false; 
                }
            }

            if (!isHeaderPresent)
            {
                return this.CreateProblemsAsError(ruleDescriptor, elementName, modelElement, new List<TSqlFragment> { fragment });
            }
            return null;
        }
    }
}

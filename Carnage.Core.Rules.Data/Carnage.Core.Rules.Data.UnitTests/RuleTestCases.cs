//------------------------------------------------------------------------------
// <copyright company="Microsoft">
//   Copyright 2013 Microsoft
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//------------------------------------------------------------------------------

namespace Carnage.Core.Rules.Data.UnitTests
{
    using Microsoft.SqlServer.Dac.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Basic test cases to validate the rule samples.
    /// Many test cases have be extended to use baselines as this can make validation easier - baselined rule tests
    /// support converting a set of input TSQL scripts into a model, running analysis against this and then comparing the
    /// results to an expected baseline. The first time you add a test and run analysis you would verify the output created
    /// looks correct, and if this is true you would update your baseline file to match this.
    /// </summary>
    [TestClass]
    public class RuleTestCases
    {
        /// <summary>
        /// TestContext for a test is automatically inserted by the unit test framework
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// This test uses input scripts saved in the "TestScripts\AvoidWaitForDelayRule" folder and compares the
        /// results to the "AvoidWaitForDelayRule-Baseline.txt file in that directory. If you wanted to add extra test cases
        /// just add in new sql files and run the test. The failure message will include links to the output file - if all
        /// the problems look correct there, then you can simply copy its contents into the baseline file and rerun the test.
        /// 
        /// This is a standard approach used inside the team and is very useful for testing rules since all you need is a tiny
        /// amount of test code and some good examples that show where your rule should/should not highlight a problem.
        /// </summary>
        [TestMethod]
        public void TestAvoidWaitForDelay()
        {
            using (BaselinedRuleTest test = new BaselinedRuleTest(
                this.TestContext,
                "AvoidWaitForDelayRule",
                new TSqlModelOptions(),
                SqlServerVersion.Sql120))
            {
                // Since this test verifies results against a baseline file, we don't need to do any extra verification
                test.RunTest(RuleIdentities.AvoidWaitForDelayRuleId);
            }
        }

        [TestMethod]
        public void TestDoNotUseSelectAll()
        {
            using (BaselinedRuleTest test = new BaselinedRuleTest(
                this.TestContext,
                "DoNotUseSelectAllRule",
                new TSqlModelOptions(),
                SqlServerVersion.Sql120))
            {
                // Since this test verifies results against a baseline file, we don't need to do any extra verification
                test.RunTest(RuleIdentities.DoNotUseSelectAllRuleId);
            }
        }

        [TestMethod]
        public void KeywordsMustBeUppercased()
        {
            using (BaselinedRuleTest test = new BaselinedRuleTest(
               this.TestContext,
               "DoNotUseLowerCaseKeywords",
               new TSqlModelOptions(),
               SqlServerVersion.Sql120))
            {
                // Since this test verifies results against a baseline file, we don't need to do any extra verification
                test.RunTest(RuleIdentities.KeywordsUppercaseRuleId);
            }
        }

        //[TestMethod]
        //public void UseAliasSparingly()
        //{
        //    using (BaselinedRuleTest test = new BaselinedRuleTest(
        //      TestContext,
        //      "UseAliasSparingly",
        //      new TSqlModelOptions(),
        //      SqlServerVersion.Sql120))
        //    {
        //        // Since this test verifies results against a baseline file, we don't need to do any extra verification
        //        test.RunTest(RuleIdentities.TableAliasRuleId);
        //    }
        //}
    }
}

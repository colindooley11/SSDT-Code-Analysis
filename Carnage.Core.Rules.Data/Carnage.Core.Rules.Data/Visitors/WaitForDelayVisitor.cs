namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class WaitForDelayVisitor : TSqlConcreteFragmentVisitor
    {
        public WaitForDelayVisitor()
        {
            this.WaitForDelayStatements = new List<WaitForStatement>();
        }

        public IList<WaitForStatement> WaitForDelayStatements { get; private set; }

        public override void ExplicitVisit(WaitForStatement node)
        {
            if (node.WaitForOption == WaitForOption.Delay)
            {
                this.WaitForDelayStatements.Add(node);
            }
        }
    }
}
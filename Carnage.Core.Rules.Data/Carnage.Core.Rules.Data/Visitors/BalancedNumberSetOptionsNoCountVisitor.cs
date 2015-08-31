namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class BalancedNumberSetOptionsNoCountVisitor : TSqlFragmentVisitor
    {
        public BalancedNumberSetOptionsNoCountVisitor()
        {
            this.SetStatements = new List<PredicateSetStatement>();
        }

        public List<PredicateSetStatement> SetStatements { get; set; }

        public override void ExplicitVisit(PredicateSetStatement node)
        {
            if (node.Options == SetOptions.NoCount)
            {
                this.SetStatements.Add(node);  
            }
        }
    }
}

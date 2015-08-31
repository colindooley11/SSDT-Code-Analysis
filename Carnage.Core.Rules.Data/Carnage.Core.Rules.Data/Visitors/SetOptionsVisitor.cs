namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SetOptionsVisitor : TSqlFragmentVisitor
    {
        public SetOptionsVisitor()
        {
            this.InvalidSetStatements = new List<PredicateSetStatement>();
        }

        public IList<PredicateSetStatement> InvalidSetStatements { get; private set; }

        public override void ExplicitVisit(PredicateSetStatement node)
        {
            if (node.Options != SetOptions.NoCount)
            {
                this.InvalidSetStatements.Add(node);
            }
        }
    }
}

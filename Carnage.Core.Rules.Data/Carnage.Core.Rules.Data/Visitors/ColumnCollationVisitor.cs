namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ColumnCollationVisitor : TSqlFragmentVisitor
    {
        public ColumnCollationVisitor()
        {
            this.ColumnDefinitions = new List<ColumnDefinition>();
        }

        public IList<ColumnDefinition> ColumnDefinitions { get; private set; }

        public override void ExplicitVisit(ColumnDefinition node)
        {
            if (node.Collation != null)
            {
                this.ColumnDefinitions.Add(node);
            }
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class TableAliasVisitor : TSqlFragmentVisitor
    {
        public TableAliasVisitor()
        {
            this.NamedTableReferences = new List<NamedTableReference>();
        }

        public IList<NamedTableReference> NamedTableReferences { get; private set; }

        public override void ExplicitVisit(NamedTableReference node)
        {
            if (node.Alias != null && !string.IsNullOrEmpty(node.Alias.Value))
            {
                this.NamedTableReferences.Add(node);
            }
        }
    }
}
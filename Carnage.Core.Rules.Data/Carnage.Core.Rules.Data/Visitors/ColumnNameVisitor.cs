namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ColumnNameVisitor : TSqlFragmentVisitor
    {
        public ColumnNameVisitor()
        {
            this.InvalidInsertStatementsWithoutColumnNames = new List<InsertStatement>();
        }

        public IList<InsertStatement> InvalidInsertStatementsWithoutColumnNames { get; private set; }

        public override void ExplicitVisit(InsertStatement node)
        {
            if (node.InsertSpecification.Columns.Count == 0)
            {
                this.InvalidInsertStatementsWithoutColumnNames.Add(node);
            }
        }
    }
}

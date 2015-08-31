namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SelectStatmentVisitor : TSqlFragmentVisitor
    {
        public SelectStatmentVisitor()
        {
            this.SelectStatements = new List<SelectStatement>();
        }

        public IList<SelectStatement> SelectStatements { get; private set; }

        public override void ExplicitVisit(SelectStatement node)
        {
            this.SelectStatements.Add(node);
        }
    }
}
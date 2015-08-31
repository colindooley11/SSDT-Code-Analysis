namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class InsertStatementVisitor : TSqlFragmentVisitor
    {
        public InsertStatementVisitor()
        {
            this.InsertStatements = new List<InsertStatement>();
        }

        public IList<InsertStatement> InsertStatements { get; private set; }

        public override void ExplicitVisit(InsertStatement node)
        {
            this.InsertStatements.Add(node);
        }
    }
}
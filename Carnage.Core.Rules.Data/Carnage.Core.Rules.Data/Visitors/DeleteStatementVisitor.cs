namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DeleteStatementVisitor : TSqlFragmentVisitor
    {
        public DeleteStatementVisitor()
        {
            this.DeleteStatements = new List<DeleteStatement>();
        }

        public IList<DeleteStatement> DeleteStatements { get; private set; }

        public override void ExplicitVisit(DeleteStatement node)
        {
            this.DeleteStatements.Add(node);
        }
    }
}
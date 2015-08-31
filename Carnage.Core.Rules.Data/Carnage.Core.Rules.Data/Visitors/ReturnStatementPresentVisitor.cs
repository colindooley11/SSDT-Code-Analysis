namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class ReturnStatementPresentVisitor : TSqlFragmentVisitor
    {
        public ReturnStatementPresentVisitor()
        {
            this.ReturnStatements = new List<ReturnStatement>();
        }

        public IList<ReturnStatement> ReturnStatements { get; private set; }

        public override void ExplicitVisit(ReturnStatement node)
        {
            this.ReturnStatements.Add(node);
        }
    }
}
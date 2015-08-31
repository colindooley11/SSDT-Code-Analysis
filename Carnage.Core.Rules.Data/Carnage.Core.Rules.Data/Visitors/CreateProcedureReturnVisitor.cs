namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CreateProcedureReturnVisitor : TSqlFragmentVisitor
    {
        public CreateProcedureReturnVisitor()
        {
            this.ReturnStatements = new List<ReturnStatement>();
        }

        public IList<ReturnStatement> ReturnStatements { get; private set; }

        public override void ExplicitVisit(CreateProcedureStatement node)
        {
            var visitor = new ReturnStatementPresentVisitor();
            node.Accept(visitor);
            this.ReturnStatements = visitor.ReturnStatements;
        }


    }

}
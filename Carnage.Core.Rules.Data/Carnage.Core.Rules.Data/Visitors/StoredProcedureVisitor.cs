namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class StoredProcedureVisitor : TSqlFragmentVisitor
    {
        public StoredProcedureVisitor()
        {
            this.CreateTableStatements = new List<CreateTableStatement>();
            this.DropTableStatements = new List<DropTableStatement>();
            this.AlterTableStatements = new List<AlterTableStatement>();
        }

        public IList<CreateTableStatement> CreateTableStatements { get; private set; }

        public IList<DropTableStatement> DropTableStatements { get; private set; }

        public IList<AlterTableStatement> AlterTableStatements { get; private set; }

        public override void ExplicitVisit(CreateProcedureStatement node)
        {
            var visitor = new DdlVisitor();

            node.Accept(visitor);

            this.AlterTableStatements = visitor.AlterTableStatements;
            this.DropTableStatements = visitor.DropTableStatements;
            this.CreateTableStatements = visitor.CreateTableStatements;
        }
    }
}
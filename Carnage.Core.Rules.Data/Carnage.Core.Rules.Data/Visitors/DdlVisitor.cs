namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DdlVisitor : TSqlFragmentVisitor
    {
        public DdlVisitor()
        {
            this.CreateTableStatements = new List<CreateTableStatement>();
            this.DropTableStatements = new List<DropTableStatement>();
            this.AlterTableStatements = new List<AlterTableStatement>();
        }

        public IList<CreateTableStatement> CreateTableStatements { get; private set; }

        public IList<DropTableStatement> DropTableStatements { get; private set; }

        public IList<AlterTableStatement> AlterTableStatements { get; private set; }

        public override void ExplicitVisit(CreateTableStatement node)
        {
            this.CreateTableStatements.Add(node);
        }

        public override void ExplicitVisit(DropTableStatement node)
        {
            this.DropTableStatements.Add(node);
        }

        public override void ExplicitVisit(AlterTableStatement node)
        {
            this.AlterTableStatements.Add(node);
        }
    }
}
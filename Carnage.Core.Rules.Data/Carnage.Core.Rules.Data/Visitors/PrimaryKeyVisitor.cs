namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class PrimaryKeyVisitor : TSqlFragmentVisitor
    {
        public PrimaryKeyVisitor()
        {
            this.CreateTableStatements = new List<CreateTableStatement>();
        }

        public IList<CreateTableStatement> CreateTableStatements { get; private set; }

        public override void ExplicitVisit(CreateTableStatement node)
        {
            foreach (var columnDefinition in node.Definition.ColumnDefinitions)
            {
                if (columnDefinition.IdentityOptions == null &&
                    columnDefinition.Constraints.Any(constraint => constraint is UniqueConstraintDefinition && ((UniqueConstraintDefinition)constraint).IsPrimaryKey))
                {
                    this.CreateTableStatements.Add(node);
                }
            }
        }
    }
}
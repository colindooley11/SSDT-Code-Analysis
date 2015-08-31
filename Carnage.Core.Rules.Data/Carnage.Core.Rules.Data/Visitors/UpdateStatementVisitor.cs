namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class UpdateStatementVisitor : TSqlFragmentVisitor
    {
        public UpdateStatementVisitor()
        {
            this.UpdateStatements = new List<UpdateStatement>();
        }

        public IList<UpdateStatement> UpdateStatements { get; private set; }

        public override void ExplicitVisit(UpdateStatement node)
        {
            this.UpdateStatements.Add(node);
        }
    }
}
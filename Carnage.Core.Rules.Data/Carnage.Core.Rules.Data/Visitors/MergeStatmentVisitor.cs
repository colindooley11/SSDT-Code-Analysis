namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class MergeStatmentVisitor : TSqlFragmentVisitor
    {
        public MergeStatmentVisitor()
        {
            this.MergeStatements = new List<MergeStatement>();
        }

        public IList<MergeStatement> MergeStatements { get; private set; }

        public override void ExplicitVisit(MergeStatement node)
        {
            this.MergeStatements.Add(node);
        }
    }
}
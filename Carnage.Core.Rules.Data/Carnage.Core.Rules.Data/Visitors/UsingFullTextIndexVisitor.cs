namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class UsingFullTextIndexVisitor : TSqlConcreteFragmentVisitor
    {
        public UsingFullTextIndexVisitor()
        {
            this.FullTextIndexes = new List<CreateFullTextIndexStatement>();
        }

        public IList<CreateFullTextIndexStatement> FullTextIndexes { get; private set; }

        public override void ExplicitVisit(CreateFullTextIndexStatement node)
        {
            this.FullTextIndexes.Add(node); 
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class HintsVisitor : TSqlFragmentVisitor
    {
        public HintsVisitor()
        {
            this.Hints = new List<TSqlFragment>();
        }

        public IList<TSqlFragment> Hints { get; private set; }

        public override void ExplicitVisit(ForceSeekTableHint node)
        {
            this.Hints.Add(node);
        }

        public override void ExplicitVisit(IndexTableHint node)
        {
            this.Hints.Add(node);
        }

        public override void ExplicitVisit(LiteralOptimizerHint node)
        {
            this.Hints.Add(node);
        }

        public override void ExplicitVisit(LiteralTableHint node)
        {
            this.Hints.Add(node);
        }

        public override void ExplicitVisit(OptimizerHint node)
        {
            this.Hints.Add(node);
        }

        public override void ExplicitVisit(OptimizeForOptimizerHint node)
        {
            this.Hints.Add(node);
        }

        public override void ExplicitVisit(TableHint node)
        {
            this.Hints.Add(node);
        }

        public override void ExplicitVisit(TableHintsOptimizerHint node)
        {
            this.Hints.Add(node);
        }
    }
}
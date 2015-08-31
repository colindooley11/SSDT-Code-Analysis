namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class SelectStarVisitor : TSqlConcreteFragmentVisitor
    {
        public SelectStarVisitor()
        {
            this.SelectStarExpressions = new List<SelectStarExpression>();
        }
        
        public IList<SelectStarExpression> SelectStarExpressions { get; private set; }

        public override void ExplicitVisit(SelectStarExpression node)
        {
            this.SelectStarExpressions.Add(node);
        }
    }
}   
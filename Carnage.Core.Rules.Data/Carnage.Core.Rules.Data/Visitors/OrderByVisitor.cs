namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class OrderByVisitor : TSqlFragmentVisitor
    {
        public OrderByVisitor()
        {
            this.InvalidOrderByClauseWithNumber = new List<OrderByClause>();
        }

        public IList<OrderByClause> InvalidOrderByClauseWithNumber { get; private set; }

        public override void ExplicitVisit(OrderByClause node)
        {
            if (node.OrderByElements != null)
            {
                foreach (var element in node.OrderByElements)
                {
                    if (element.Expression is IntegerLiteral)
                    {
                        this.InvalidOrderByClauseWithNumber.Add(node);
                        break; 
                    }
                }
            }
        }
    }
}
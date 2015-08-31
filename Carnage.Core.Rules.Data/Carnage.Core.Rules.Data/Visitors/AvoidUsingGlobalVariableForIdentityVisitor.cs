namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class AvoidUsingGlobalVariableForIdentityVisitor : TSqlFragmentVisitor
    {
        public AvoidUsingGlobalVariableForIdentityVisitor()
        {
            this.InvalidVariables = new List<GlobalVariableExpression>();
        }

        public IList<GlobalVariableExpression> InvalidVariables { get; private set; }

        public override void ExplicitVisit(GlobalVariableExpression node)
        {
                if (node.Name.ToLower().Contains("identity"))
                {
                    this.InvalidVariables.Add(node);
                }
        }
    }
}

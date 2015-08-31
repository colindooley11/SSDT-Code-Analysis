namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class UsingIndexedViewsVisitor : TSqlConcreteFragmentVisitor
    {
        public UsingIndexedViewsVisitor()
        {
            this.IndexedViews = new List<CreateViewStatement>();
            this.WithBindings = new List<ViewOption>();
        }

        public IList<CreateViewStatement> IndexedViews { get; private set; }
       
        public IList<ViewOption> WithBindings { get; private set; }

        public override void ExplicitVisit(CreateViewStatement node)
        {
            foreach (var viewOption in node.ViewOptions)
            {
                if (viewOption.OptionKind == ViewOptionKind.SchemaBinding)
                {
                    this.IndexedViews.Add(node);
                    this.WithBindings.Add(viewOption);
                    break;
                }
            }
        }
    }
}
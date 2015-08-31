namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class CreateProcedureVisitor : TSqlFragmentVisitor
    {
        public CreateProcedureVisitor()
        {
            this.SetStatements = new List<PredicateSetStatement>();
        }

        public List<PredicateSetStatement> SetStatements { get; private set; }

        public bool ShouldRunBalancedCheck { get; private set; }

        public override void ExplicitVisit(CreateProcedureStatement node)
        {
            var setOptionsVisitor = new BalancedNumberSetOptionsNoCountVisitor();
            node.Accept(setOptionsVisitor);
       
            var selectStatementVisitor = new SelectStatmentVisitor();
            node.Accept(selectStatementVisitor);
            if (selectStatementVisitor.SelectStatements.Any())
            {
                this.ShouldRunBalancedCheck = true; 
            }

            var deleteStatementVisitor = new DeleteStatementVisitor();
            node.Accept(deleteStatementVisitor);
            if (deleteStatementVisitor.DeleteStatements.Any())
            {
                this.ShouldRunBalancedCheck = true;
            }

            var updateStatementVisitor = new UpdateStatementVisitor();
            node.Accept(updateStatementVisitor);
            if (updateStatementVisitor.UpdateStatements.Any())
            {
                this.ShouldRunBalancedCheck = true;
            }

            var insertStatmentVisitor = new InsertStatementVisitor();
            node.Accept(insertStatmentVisitor);
            if (insertStatmentVisitor.InsertStatements.Any())
            {
                this.ShouldRunBalancedCheck = true;
            }

            var mergeStatementVisitor = new MergeStatmentVisitor();
            node.Accept(mergeStatementVisitor);
            if (mergeStatementVisitor.MergeStatements.Any())
            {
                this.ShouldRunBalancedCheck = true;
            }

            this.SetStatements = setOptionsVisitor.SetStatements;
        }
    }
}
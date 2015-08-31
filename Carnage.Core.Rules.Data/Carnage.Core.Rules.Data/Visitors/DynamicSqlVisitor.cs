namespace Carnage.Core.Rules.Data.Visitors
{
    using System;
    using System.Collections.Generic;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DynamicSqlVisitor : TSqlFragmentVisitor
    {
        public DynamicSqlVisitor()
        {
            this.ExecuteStatements = new List<ExecuteStatement>();
        }

        public IList<ExecuteStatement> ExecuteStatements { get; private set; }

        public override void ExplicitVisit(ExecuteStatement node)
        {
            if (node.ExecuteSpecification.ExecutableEntity is ExecutableStringList)
            {
                this.ExecuteStatements.Add(node);
            }
            else
            {
                var procedureRef = node.ExecuteSpecification.ExecutableEntity as ExecutableProcedureReference;

                if (procedureRef != null)
                {
                    if (string.Equals("sp_executesql", procedureRef.ProcedureReference.ProcedureReference.Name.BaseIdentifier.Value, StringComparison.OrdinalIgnoreCase))
                    {
                        this.ExecuteStatements.Add(node);
                    }
                }                
            }
        }
    }
}
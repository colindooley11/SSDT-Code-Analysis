namespace Carnage.Core.Rules.Data.Visitors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    public class SchemaVisitor : TSqlFragmentVisitor
    {
        public SchemaVisitor()
        {
            this.NamedTableReferences = new List<NamedTableReference>();
            this.FunctionCalls = new List<FunctionCall>();
            this.ProcedureReferences = new List<ExecutableProcedureReference>();
        }

        public IList<NamedTableReference> NamedTableReferences { get; private set; }

        public IList<FunctionCall> FunctionCalls { get; private set; }

        public IList<ExecutableProcedureReference> ProcedureReferences { get; private set; }

        public override void ExplicitVisit(NamedTableReference node)
        {
            if (node.SchemaObject.SchemaIdentifier == null && node.Alias != null && node.Alias.Value.ToList().TrueForAll(char.IsUpper))
            {
                this.NamedTableReferences.Add(node);
            }
        }

        public override void ExplicitVisit(ExecutableProcedureReference node)
        {
            if (node.ProcedureReference.ProcedureReference.Name.BaseIdentifier.Value.StartsWith("usp", StringComparison.OrdinalIgnoreCase))
            {
                if (node.ProcedureReference.ProcedureReference.Name.SchemaIdentifier == null)
                {
                    this.ProcedureReferences.Add(node);
                }
            }
        }

        public override void ExplicitVisit(FunctionCall node)
        {
            if (node.FunctionName.Value.StartsWith("ufn", StringComparison.OrdinalIgnoreCase))
            {
                if (!(node.CallTarget is MultiPartIdentifierCallTarget))
                {
                    this.FunctionCalls.Add(node);
                }
            }
        }

        private void Process(NamedTableReference namedTableReference)
        {
            if (IsInViolationOfRule(namedTableReference))
            {
                this.NamedTableReferences.Add(namedTableReference);
            }
        }

        private void Pro(QualifiedJoin join)
        {
            if (join != null)
            {
                if (join.FirstTableReference is QualifiedJoin)
                {
                    this.Pro(join.FirstTableReference as QualifiedJoin);
                }

                if (join.FirstTableReference is NamedTableReference)
                {
                    this.Process(join.FirstTableReference as NamedTableReference);
                }

                if (join.SecondTableReference is QualifiedJoin)
                {
                    this.Pro(join.SecondTableReference as QualifiedJoin);
                }

                if (join.SecondTableReference is NamedTableReference)
                {
                    this.Process(join.SecondTableReference as NamedTableReference);
                }
            }
        }

        public override void ExplicitVisit(FromClause node)
        {
            foreach (var tableReference in node.TableReferences)
            {
                var namedTableReference = tableReference as NamedTableReference;
                var join = tableReference as QualifiedJoin;

                if (namedTableReference != null)
                {
                    this.Process(namedTableReference);
                }
                else
                {
                    this.Pro(join);
                }

                //if (join != null)
                //{
                //    if (join.FirstTableReference is NamedTableReference)
                //    {
                //        namedTableReference = join.FirstTableReference as NamedTableReference;

                //        if (IsInViolationOfRule(namedTableReference))
                //        {
                //            this.NamedTableReferences.Add(namedTableReference);
                //        }
                //    }

                //    if (join.SecondTableReference is NamedTableReference)
                //    {
                //        namedTableReference = join.SecondTableReference as NamedTableReference;

                //        if (IsInViolationOfRule(namedTableReference))
                //        {
                //            this.NamedTableReferences.Add(namedTableReference);
                //        }
                //    }
                //}
                //else
                //{
                    
                //}

                //var join = tableReference as QualifiedJoin;

                //if (join != null)
                //{
                //    join.QualifiedJoinType


                //}
                //else
                //{
                //    if (IsInViolationOfRule(namedTableReference))
                //    {
                //        this.NamedTableReferences.Add(namedTableReference);
                //    }
                //}
            }
        }

        private static bool IsInViolationOfRule(NamedTableReference namedTableReference)
        {
            if (namedTableReference.SchemaObject.SchemaIdentifier == null)
            {
                return true;
            }

            return false;
        }
    }
}
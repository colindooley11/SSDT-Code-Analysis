namespace Carnage.Core.Rules.Data.Visitors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class DataTypesVisitor : TSqlFragmentVisitor
    {
        public DataTypesVisitor()
        {
            this.ColumnDefinitions = new List<ColumnDefinition>();
            this.ProcedureParameters = new List<ProcedureParameter>();
        }

        public IList<ColumnDefinition> ColumnDefinitions { get; private set; }

        public IList<ProcedureParameter> ProcedureParameters { get; private set; }

        public override void ExplicitVisit(ColumnDefinition node)
        {
            if (ContainsUppercase(node.DataType.Name.BaseIdentifier.Value))
            {
                this.ColumnDefinitions.Add(node);    
            }
        }

        public override void ExplicitVisit(ProcedureParameter node)
        {
            if (ContainsUppercase(node.DataType.Name.BaseIdentifier.Value))
            {
                this.ProcedureParameters.Add(node);    
            }
        }

        private static bool ContainsUppercase(string dataType)
        {
            if (dataType.StartsWith("udt", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            return dataType.ToCharArray().Any(char.IsUpper);
        }
    }
}
namespace Carnage.Core.Rules.Data.Visitors
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.SqlServer.TransactSql.ScriptDom;

    internal class InvalidTypesVisitor : TSqlFragmentVisitor
    {
        public InvalidTypesVisitor()
        {
            this.ColumnDefinitions = new List<ColumnDefinition>();
            this.ProcedureParameters = new List<ProcedureParameter>();
        }

        public IList<ColumnDefinition> ColumnDefinitions { get; private set; }

        public IList<ProcedureParameter> ProcedureParameters { get; private set; }

        public override void ExplicitVisit(ColumnDefinition node)
        {
            if (IsDataTypeInvalid(node.DataType))
            {
                this.ColumnDefinitions.Add(node);
            }
        }

        public override void ExplicitVisit(ProcedureParameter node)
        {
            if (IsDataTypeInvalid(node.DataType))
            {
                this.ProcedureParameters.Add(node);
            }
        }

        private static bool IsDataTypeInvalid(DataTypeReference dataTypeReference)
        {
            var dataType = dataTypeReference as SqlDataTypeReference;

            if (dataType == null)
            {
                return false;
            }

            var invalidDataTypes = new[] { SqlDataTypeOption.Text, SqlDataTypeOption.NText, SqlDataTypeOption.Image };

            return invalidDataTypes.Contains(dataType.SqlDataTypeOption) ||
                   (dataType.Parameters.Any() && dataType.Parameters.FirstOrDefault(x => x.LiteralType == LiteralType.Max) != null);
        }
    }
}
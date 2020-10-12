using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIndExpressions
    {
        public string IndexOwner { get; set; }
        public string IndexName { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string ColumnExpression { get; set; }
        public decimal ColumnPosition { get; set; }
    }
}

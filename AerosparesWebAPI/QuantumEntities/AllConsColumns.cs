using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllConsColumns
    {
        public string Owner { get; set; }
        public string ConstraintName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public decimal? Position { get; set; }
    }
}

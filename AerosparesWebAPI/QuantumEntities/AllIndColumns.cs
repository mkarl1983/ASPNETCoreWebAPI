using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIndColumns
    {
        public string IndexOwner { get; set; }
        public string IndexName { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public decimal ColumnPosition { get; set; }
        public decimal ColumnLength { get; set; }
        public decimal? CharLength { get; set; }
        public string Descend { get; set; }
    }
}

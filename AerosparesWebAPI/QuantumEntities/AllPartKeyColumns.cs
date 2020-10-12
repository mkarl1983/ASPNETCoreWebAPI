using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllPartKeyColumns
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string ObjectType { get; set; }
        public string ColumnName { get; set; }
        public decimal? ColumnPosition { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDimLevelKey
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string LevelName { get; set; }
        public decimal KeyPosition { get; set; }
        public string ColumnName { get; set; }
    }
}

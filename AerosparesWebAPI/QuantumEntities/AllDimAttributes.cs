using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDimAttributes
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string AttributeName { get; set; }
        public string LevelName { get; set; }
        public string ColumnName { get; set; }
        public string Inferred { get; set; }
    }
}

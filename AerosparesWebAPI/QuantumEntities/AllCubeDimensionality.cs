using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubeDimensionality
    {
        public string Owner { get; set; }
        public string CubeName { get; set; }
        public string DimensionName { get; set; }
        public decimal OrderNum { get; set; }
        public decimal? IsSparse { get; set; }
        public string EtAttrPrefix { get; set; }
    }
}

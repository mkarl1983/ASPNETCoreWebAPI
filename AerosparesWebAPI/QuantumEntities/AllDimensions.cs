using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDimensions
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string Invalid { get; set; }
        public string CompileState { get; set; }
        public decimal? Revision { get; set; }
    }
}

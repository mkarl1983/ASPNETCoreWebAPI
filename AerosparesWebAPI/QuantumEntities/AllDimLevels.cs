using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDimLevels
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string LevelName { get; set; }
        public decimal? NumColumns { get; set; }
        public string DetailobjOwner { get; set; }
        public string DetailobjName { get; set; }
        public string SkipWhenNull { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubeHierLevels
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string HierarchyName { get; set; }
        public string LevelName { get; set; }
        public decimal OrderNum { get; set; }
        public string Description { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubeHierarchies
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string HierarchyName { get; set; }
        public string HierarchyType { get; set; }
        public string Description { get; set; }
        public decimal? IsRagged { get; set; }
        public decimal? IsSkipLevel { get; set; }
    }
}

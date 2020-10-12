using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubes
    {
        public string Owner { get; set; }
        public string CubeName { get; set; }
        public string AwName { get; set; }
        public string ConsistentSolveSpec { get; set; }
        public string Description { get; set; }
        public string SparseType { get; set; }
        public string PrecomputeCondition { get; set; }
        public decimal? PrecomputePercent { get; set; }
        public decimal? PrecomputePercentTop { get; set; }
        public string PartitionDimensionName { get; set; }
        public string PartitionHierarchyName { get; set; }
        public string PartitionLevelName { get; set; }
    }
}

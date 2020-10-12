using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDimJoinKey
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public decimal DimKeyId { get; set; }
        public string LevelName { get; set; }
        public decimal KeyPosition { get; set; }
        public string HierarchyName { get; set; }
        public string ChildJoinOwner { get; set; }
        public string ChildJoinTable { get; set; }
        public string ChildJoinColumn { get; set; }
        public string ChildLevelName { get; set; }
    }
}

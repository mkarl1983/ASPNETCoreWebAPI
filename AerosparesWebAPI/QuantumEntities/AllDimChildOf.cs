using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDimChildOf
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string HierarchyName { get; set; }
        public decimal Position { get; set; }
        public string ChildLevelName { get; set; }
        public string JoinKeyId { get; set; }
        public string ParentLevelName { get; set; }
    }
}

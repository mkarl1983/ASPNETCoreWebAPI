using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubeAttrVisibility
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string AttributeName { get; set; }
        public string HierarchyName { get; set; }
        public string LevelName { get; set; }
        public string FromType { get; set; }
        public string ToType { get; set; }
    }
}

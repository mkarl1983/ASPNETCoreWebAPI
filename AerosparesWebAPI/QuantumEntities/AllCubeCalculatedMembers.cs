using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubeCalculatedMembers
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string MemberName { get; set; }
        public string IsCustomAggregate { get; set; }
        public string StorageType { get; set; }
        public string Expression { get; set; }
    }
}

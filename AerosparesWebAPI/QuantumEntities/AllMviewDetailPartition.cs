using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviewDetailPartition
    {
        public string Owner { get; set; }
        public string MviewName { get; set; }
        public string DetailobjOwner { get; set; }
        public string DetailobjName { get; set; }
        public string DetailPartitionName { get; set; }
        public decimal? DetailPartitionPosition { get; set; }
        public string Freshness { get; set; }
    }
}

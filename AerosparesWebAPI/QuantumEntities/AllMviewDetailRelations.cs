using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviewDetailRelations
    {
        public string Owner { get; set; }
        public string MviewName { get; set; }
        public string DetailobjOwner { get; set; }
        public string DetailobjName { get; set; }
        public string DetailobjType { get; set; }
        public string DetailobjAlias { get; set; }
        public string DetailobjPct { get; set; }
        public decimal? NumFreshPctPartitions { get; set; }
        public decimal? NumStalePctPartitions { get; set; }
    }
}

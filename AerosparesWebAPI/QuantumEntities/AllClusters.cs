using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllClusters
    {
        public string Owner { get; set; }
        public string ClusterName { get; set; }
        public string TablespaceName { get; set; }
        public decimal? PctFree { get; set; }
        public decimal? PctUsed { get; set; }
        public decimal? KeySize { get; set; }
        public decimal IniTrans { get; set; }
        public decimal MaxTrans { get; set; }
        public decimal? InitialExtent { get; set; }
        public decimal? NextExtent { get; set; }
        public decimal MinExtents { get; set; }
        public decimal MaxExtents { get; set; }
        public decimal? PctIncrease { get; set; }
        public decimal? Freelists { get; set; }
        public decimal? FreelistGroups { get; set; }
        public decimal? AvgBlocksPerKey { get; set; }
        public string ClusterType { get; set; }
        public string Function { get; set; }
        public decimal? Hashkeys { get; set; }
        public string Degree { get; set; }
        public string Instances { get; set; }
        public string Cache { get; set; }
        public string BufferPool { get; set; }
        public string FlashCache { get; set; }
        public string CellFlashCache { get; set; }
        public string SingleTable { get; set; }
        public string Dependencies { get; set; }
    }
}

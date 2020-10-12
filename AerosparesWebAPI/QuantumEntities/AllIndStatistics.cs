using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIndStatistics
    {
        public string Owner { get; set; }
        public string IndexName { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public decimal? PartitionPosition { get; set; }
        public string SubpartitionName { get; set; }
        public decimal? SubpartitionPosition { get; set; }
        public string ObjectType { get; set; }
        public decimal? Blevel { get; set; }
        public decimal? LeafBlocks { get; set; }
        public decimal? DistinctKeys { get; set; }
        public decimal? AvgLeafBlocksPerKey { get; set; }
        public decimal? AvgDataBlocksPerKey { get; set; }
        public decimal? ClusteringFactor { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? AvgCachedBlocks { get; set; }
        public decimal? AvgCacheHitRatio { get; set; }
        public decimal? SampleSize { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public string GlobalStats { get; set; }
        public string UserStats { get; set; }
        public string StattypeLocked { get; set; }
        public string StaleStats { get; set; }
    }
}

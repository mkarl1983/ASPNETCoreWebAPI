using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabStatistics
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public decimal? PartitionPosition { get; set; }
        public string SubpartitionName { get; set; }
        public decimal? SubpartitionPosition { get; set; }
        public string ObjectType { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? Blocks { get; set; }
        public decimal? EmptyBlocks { get; set; }
        public decimal? AvgSpace { get; set; }
        public decimal? ChainCnt { get; set; }
        public decimal? AvgRowLen { get; set; }
        public decimal? AvgSpaceFreelistBlocks { get; set; }
        public decimal? NumFreelistBlocks { get; set; }
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

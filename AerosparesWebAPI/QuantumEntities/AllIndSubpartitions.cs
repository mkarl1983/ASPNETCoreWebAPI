﻿using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIndSubpartitions
    {
        public string IndexOwner { get; set; }
        public string IndexName { get; set; }
        public string PartitionName { get; set; }
        public string SubpartitionName { get; set; }
        public string HighValue { get; set; }
        public decimal HighValueLength { get; set; }
        public decimal? SubpartitionPosition { get; set; }
        public string Status { get; set; }
        public string TablespaceName { get; set; }
        public decimal PctFree { get; set; }
        public decimal IniTrans { get; set; }
        public decimal MaxTrans { get; set; }
        public decimal? InitialExtent { get; set; }
        public decimal? NextExtent { get; set; }
        public decimal? MinExtent { get; set; }
        public decimal? MaxExtent { get; set; }
        public decimal? MaxSize { get; set; }
        public decimal? PctIncrease { get; set; }
        public decimal? Freelists { get; set; }
        public decimal? FreelistGroups { get; set; }
        public string Logging { get; set; }
        public string Compression { get; set; }
        public decimal? Blevel { get; set; }
        public decimal? LeafBlocks { get; set; }
        public decimal? DistinctKeys { get; set; }
        public decimal? AvgLeafBlocksPerKey { get; set; }
        public decimal? AvgDataBlocksPerKey { get; set; }
        public decimal? ClusteringFactor { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? SampleSize { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public string BufferPool { get; set; }
        public string FlashCache { get; set; }
        public string CellFlashCache { get; set; }
        public string UserStats { get; set; }
        public string GlobalStats { get; set; }
        public string Interval { get; set; }
        public string SegmentCreated { get; set; }
    }
}

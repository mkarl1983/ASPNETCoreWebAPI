using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabSubpartitions
    {
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public string SubpartitionName { get; set; }
        public string HighValue { get; set; }
        public decimal HighValueLength { get; set; }
        public decimal? SubpartitionPosition { get; set; }
        public string TablespaceName { get; set; }
        public decimal PctFree { get; set; }
        public decimal? PctUsed { get; set; }
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
        public string CompressFor { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? Blocks { get; set; }
        public decimal? EmptyBlocks { get; set; }
        public decimal? AvgSpace { get; set; }
        public decimal? ChainCnt { get; set; }
        public decimal? AvgRowLen { get; set; }
        public decimal? SampleSize { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public string BufferPool { get; set; }
        public string FlashCache { get; set; }
        public string CellFlashCache { get; set; }
        public string GlobalStats { get; set; }
        public string UserStats { get; set; }
        public string Interval { get; set; }
        public string SegmentCreated { get; set; }
    }
}

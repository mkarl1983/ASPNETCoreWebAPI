using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllObjectTables
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string TablespaceName { get; set; }
        public string ClusterName { get; set; }
        public string IotName { get; set; }
        public string Status { get; set; }
        public decimal? PctFree { get; set; }
        public decimal? PctUsed { get; set; }
        public decimal? IniTrans { get; set; }
        public decimal? MaxTrans { get; set; }
        public decimal? InitialExtent { get; set; }
        public decimal? NextExtent { get; set; }
        public decimal? MinExtents { get; set; }
        public decimal? MaxExtents { get; set; }
        public decimal? PctIncrease { get; set; }
        public decimal? Freelists { get; set; }
        public decimal? FreelistGroups { get; set; }
        public string Logging { get; set; }
        public string BackedUp { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? Blocks { get; set; }
        public decimal? EmptyBlocks { get; set; }
        public decimal? AvgSpace { get; set; }
        public decimal? ChainCnt { get; set; }
        public decimal? AvgRowLen { get; set; }
        public decimal? AvgSpaceFreelistBlocks { get; set; }
        public decimal? NumFreelistBlocks { get; set; }
        public string Degree { get; set; }
        public string Instances { get; set; }
        public string Cache { get; set; }
        public string TableLock { get; set; }
        public decimal? SampleSize { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public string Partitioned { get; set; }
        public string IotType { get; set; }
        public string ObjectIdType { get; set; }
        public string TableTypeOwner { get; set; }
        public string TableType { get; set; }
        public string Temporary { get; set; }
        public string Secondary { get; set; }
        public string Nested { get; set; }
        public string BufferPool { get; set; }
        public string FlashCache { get; set; }
        public string CellFlashCache { get; set; }
        public string RowMovement { get; set; }
        public string GlobalStats { get; set; }
        public string UserStats { get; set; }
        public string Duration { get; set; }
        public string SkipCorrupt { get; set; }
        public string Monitoring { get; set; }
        public string ClusterOwner { get; set; }
        public string Dependencies { get; set; }
        public string Compression { get; set; }
        public string CompressFor { get; set; }
        public string Dropped { get; set; }
        public string SegmentCreated { get; set; }
    }
}

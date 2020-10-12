using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIndexes
    {
        public string Owner { get; set; }
        public string IndexName { get; set; }
        public string IndexType { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string TableType { get; set; }
        public string Uniqueness { get; set; }
        public string Compression { get; set; }
        public decimal? PrefixLength { get; set; }
        public string TablespaceName { get; set; }
        public decimal? IniTrans { get; set; }
        public decimal? MaxTrans { get; set; }
        public decimal? InitialExtent { get; set; }
        public decimal? NextExtent { get; set; }
        public decimal? MinExtents { get; set; }
        public decimal? MaxExtents { get; set; }
        public decimal? PctIncrease { get; set; }
        public decimal? PctThreshold { get; set; }
        public decimal? IncludeColumn { get; set; }
        public decimal? Freelists { get; set; }
        public decimal? FreelistGroups { get; set; }
        public decimal? PctFree { get; set; }
        public string Logging { get; set; }
        public decimal? Blevel { get; set; }
        public decimal? LeafBlocks { get; set; }
        public decimal? DistinctKeys { get; set; }
        public decimal? AvgLeafBlocksPerKey { get; set; }
        public decimal? AvgDataBlocksPerKey { get; set; }
        public decimal? ClusteringFactor { get; set; }
        public string Status { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? SampleSize { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public string Degree { get; set; }
        public string Instances { get; set; }
        public string Partitioned { get; set; }
        public string Temporary { get; set; }
        public string Generated { get; set; }
        public string Secondary { get; set; }
        public string BufferPool { get; set; }
        public string FlashCache { get; set; }
        public string CellFlashCache { get; set; }
        public string UserStats { get; set; }
        public string Duration { get; set; }
        public decimal? PctDirectAccess { get; set; }
        public string ItypOwner { get; set; }
        public string ItypName { get; set; }
        public string Parameters { get; set; }
        public string GlobalStats { get; set; }
        public string DomidxStatus { get; set; }
        public string DomidxOpstatus { get; set; }
        public string FuncidxStatus { get; set; }
        public string JoinIndex { get; set; }
        public string IotRedundantPkeyElim { get; set; }
        public string Dropped { get; set; }
        public string Visibility { get; set; }
        public string DomidxManagement { get; set; }
        public string SegmentCreated { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllLobPartitions
    {
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string LobName { get; set; }
        public string PartitionName { get; set; }
        public string LobPartitionName { get; set; }
        public string LobIndpartName { get; set; }
        public decimal? PartitionPosition { get; set; }
        public string Composite { get; set; }
        public decimal? Chunk { get; set; }
        public decimal? Pctversion { get; set; }
        public string Cache { get; set; }
        public string InRow { get; set; }
        public string TablespaceName { get; set; }
        public string InitialExtent { get; set; }
        public string NextExtent { get; set; }
        public string MinExtents { get; set; }
        public string MaxExtents { get; set; }
        public string MaxSize { get; set; }
        public string Retention { get; set; }
        public string Minretention { get; set; }
        public string PctIncrease { get; set; }
        public string Freelists { get; set; }
        public string FreelistGroups { get; set; }
        public string Logging { get; set; }
        public string BufferPool { get; set; }
        public string FlashCache { get; set; }
        public string CellFlashCache { get; set; }
        public string Encrypt { get; set; }
        public string Compression { get; set; }
        public string Deduplication { get; set; }
        public string Securefile { get; set; }
        public string SegmentCreated { get; set; }
    }
}

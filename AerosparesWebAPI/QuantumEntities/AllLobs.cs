using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllLobs
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string SegmentName { get; set; }
        public string TablespaceName { get; set; }
        public string IndexName { get; set; }
        public decimal? Chunk { get; set; }
        public decimal? Pctversion { get; set; }
        public decimal? Retention { get; set; }
        public decimal? Freepools { get; set; }
        public string Cache { get; set; }
        public string Logging { get; set; }
        public string Encrypt { get; set; }
        public string Compression { get; set; }
        public string Deduplication { get; set; }
        public string InRow { get; set; }
        public string Format { get; set; }
        public string Partitioned { get; set; }
        public string Securefile { get; set; }
        public string SegmentCreated { get; set; }
        public string RetentionType { get; set; }
        public decimal? RetentionValue { get; set; }
    }
}

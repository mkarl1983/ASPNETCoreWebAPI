using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Comparison
    {
        public decimal ComparisonId { get; set; }
        public string ComparisonName { get; set; }
        public decimal? User { get; set; }
        public decimal? ComparisonMode { get; set; }
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public decimal? ObjectType { get; set; }
        public string RmtSchemaName { get; set; }
        public string RmtObjectName { get; set; }
        public decimal? RmtObjectType { get; set; }
        public string DblinkName { get; set; }
        public decimal? ScanMode { get; set; }
        public decimal? ScanPercent { get; set; }
        public string CylIdxVal { get; set; }
        public string NullValue { get; set; }
        public byte[] LocConvergeTag { get; set; }
        public byte[] RmtConvergeTag { get; set; }
        public decimal? MaxNumBuckets { get; set; }
        public decimal? MinRowsInBucket { get; set; }
        public decimal? Flags { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public string Spare4 { get; set; }
    }
}

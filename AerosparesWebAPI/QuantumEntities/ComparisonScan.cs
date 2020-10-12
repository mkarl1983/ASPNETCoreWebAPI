using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ComparisonScan
    {
        public decimal ComparisonId { get; set; }
        public decimal ScanId { get; set; }
        public decimal? ParentScanId { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? Status { get; set; }
        public decimal? Flags { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public string Spare4 { get; set; }
        public decimal? Spare5 { get; set; }
        public decimal? Spare6 { get; set; }
        public decimal? Spare7 { get; set; }
        public DateTime? Spare8 { get; set; }
    }
}

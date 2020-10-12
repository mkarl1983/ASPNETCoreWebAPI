using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ComparisonRowDif
    {
        public decimal ComparisonId { get; set; }
        public decimal ScanId { get; set; }
        public string LocRowid { get; set; }
        public string RmtRowid { get; set; }
        public string IdxVal { get; set; }
        public decimal? Status { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public string Spare4 { get; set; }
    }
}

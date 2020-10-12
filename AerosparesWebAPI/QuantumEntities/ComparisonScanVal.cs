using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ComparisonScanVal
    {
        public decimal ComparisonId { get; set; }
        public decimal ScanId { get; set; }
        public decimal ColumnPosition { get; set; }
        public string MinVal { get; set; }
        public string MaxVal { get; set; }
        public decimal? Flags { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public string Spare4 { get; set; }
    }
}

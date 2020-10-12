using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllComparisonScanSummary
    {
        public string Owner { get; set; }
        public string ComparisonName { get; set; }
        public decimal ScanId { get; set; }
        public decimal? ParentScanId { get; set; }
        public decimal? RootScanId { get; set; }
        public string Status { get; set; }
        public decimal? CurrentDifCount { get; set; }
        public decimal? InitialDifCount { get; set; }
        public decimal? CountRows { get; set; }
        public string ScanNulls { get; set; }
        public DateTime? LastUpdateTime { get; set; }
    }
}

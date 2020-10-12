using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabPendingStats
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public string SubpartitionName { get; set; }
        public decimal? NumRows { get; set; }
        public decimal? Blocks { get; set; }
        public decimal? AvgRowLen { get; set; }
        public decimal? SampleSize { get; set; }
        public DateTime? LastAnalyzed { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllPartColStatistics
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public string ColumnName { get; set; }
        public decimal? NumDistinct { get; set; }
        public byte[] LowValue { get; set; }
        public byte[] HighValue { get; set; }
        public decimal? Density { get; set; }
        public decimal? NumNulls { get; set; }
        public decimal? NumBuckets { get; set; }
        public decimal? SampleSize { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public string GlobalStats { get; set; }
        public string UserStats { get; set; }
        public decimal? AvgColLen { get; set; }
        public string Histogram { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlsetStatisticsOnly
    {
        public decimal SqlsetId { get; set; }
        public decimal SqlSeq { get; set; }
        public decimal PlanHashValue { get; set; }
        public decimal? ElapsedTime { get; set; }
        public decimal? CpuTime { get; set; }
        public decimal? BufferGets { get; set; }
        public decimal? DiskReads { get; set; }
        public decimal? DirectWrites { get; set; }
        public decimal? RowsProcessed { get; set; }
        public decimal? Fetches { get; set; }
        public decimal? Executions { get; set; }
        public decimal? EndOfFetchCount { get; set; }
        public decimal? OptimizerCost { get; set; }
        public string FirstLoadTime { get; set; }
        public decimal? StatPeriod { get; set; }
        public decimal? ActiveStatPeriod { get; set; }
        public DateTime? PlanTimestamp { get; set; }
        public string BindsCaptured { get; set; }
    }
}

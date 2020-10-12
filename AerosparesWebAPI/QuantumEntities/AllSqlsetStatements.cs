using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlsetStatements
    {
        public string SqlsetName { get; set; }
        public string SqlsetOwner { get; set; }
        public decimal SqlsetId { get; set; }
        public string SqlId { get; set; }
        public decimal ForceMatchingSignature { get; set; }
        public string SqlText { get; set; }
        public string ParsingSchemaName { get; set; }
        public decimal PlanHashValue { get; set; }
        public byte[] BindData { get; set; }
        public string BindsCaptured { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
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
        public byte[] OptimizerEnv { get; set; }
        public decimal? Priority { get; set; }
        public decimal? CommandType { get; set; }
        public string FirstLoadTime { get; set; }
        public decimal? StatPeriod { get; set; }
        public decimal? ActiveStatPeriod { get; set; }
        public string Other { get; set; }
        public DateTime? PlanTimestamp { get; set; }
        public decimal SqlSeq { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlsetPlans
    {
        public string SqlsetName { get; set; }
        public string SqlsetOwner { get; set; }
        public decimal SqlsetId { get; set; }
        public string SqlId { get; set; }
        public decimal ForceMatchingSignature { get; set; }
        public decimal PlanHashValue { get; set; }
        public decimal SqlSeq { get; set; }
        public string StatementId { get; set; }
        public decimal? PlanId { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Remarks { get; set; }
        public string Operation { get; set; }
        public string Options { get; set; }
        public string ObjectNode { get; set; }
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string ObjectAlias { get; set; }
        public decimal? ObjectInstance { get; set; }
        public string ObjectType { get; set; }
        public string Optimizer { get; set; }
        public decimal? SearchColumns { get; set; }
        public decimal Id { get; set; }
        public decimal? ParentId { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Position { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Cardinality { get; set; }
        public decimal? Bytes { get; set; }
        public string OtherTag { get; set; }
        public string PartitionStart { get; set; }
        public string PartitionStop { get; set; }
        public decimal? PartitionId { get; set; }
        public string Other { get; set; }
        public string Distribution { get; set; }
        public decimal? CpuCost { get; set; }
        public decimal? IoCost { get; set; }
        public decimal? TempSpace { get; set; }
        public string AccessPredicates { get; set; }
        public string FilterPredicates { get; set; }
        public string Projection { get; set; }
        public decimal? Time { get; set; }
        public string QblockName { get; set; }
        public string OtherXml { get; set; }
        public decimal? Executions { get; set; }
        public decimal? Starts { get; set; }
        public decimal? OutputRows { get; set; }
        public decimal? CrBufferGets { get; set; }
        public decimal? CuBufferGets { get; set; }
        public decimal? DiskReads { get; set; }
        public decimal? DiskWrites { get; set; }
        public decimal? ElapsedTime { get; set; }
        public decimal? LastStarts { get; set; }
        public decimal? LastOutputRows { get; set; }
        public decimal? LastCrBufferGets { get; set; }
        public decimal? LastCuBufferGets { get; set; }
        public decimal? LastDiskReads { get; set; }
        public decimal? LastDiskWrites { get; set; }
        public decimal? LastElapsedTime { get; set; }
        public string Policy { get; set; }
        public decimal? EstimatedOptimalSize { get; set; }
        public decimal? EstimatedOnepassSize { get; set; }
        public decimal? LastMemoryUsed { get; set; }
        public string LastExecution { get; set; }
        public decimal? LastDegree { get; set; }
        public decimal? TotalExecutions { get; set; }
        public decimal? OptimalExecutions { get; set; }
        public decimal? OnepassExecutions { get; set; }
        public decimal? MultipassesExecutions { get; set; }
        public decimal? ActiveTime { get; set; }
        public decimal? MaxTempsegSize { get; set; }
        public decimal? LastTempsegSize { get; set; }
    }
}

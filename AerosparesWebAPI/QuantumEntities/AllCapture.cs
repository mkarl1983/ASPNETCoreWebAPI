using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCapture
    {
        public string CaptureName { get; set; }
        public string QueueName { get; set; }
        public string QueueOwner { get; set; }
        public string RuleSetName { get; set; }
        public string RuleSetOwner { get; set; }
        public string CaptureUser { get; set; }
        public decimal? StartScn { get; set; }
        public string Status { get; set; }
        public decimal? CapturedScn { get; set; }
        public decimal? AppliedScn { get; set; }
        public string UseDatabaseLink { get; set; }
        public decimal? FirstScn { get; set; }
        public string SourceDatabase { get; set; }
        public decimal? SourceDbid { get; set; }
        public decimal? SourceResetlogsScn { get; set; }
        public decimal? SourceResetlogsTime { get; set; }
        public decimal? LogminerId { get; set; }
        public string NegativeRuleSetName { get; set; }
        public string NegativeRuleSetOwner { get; set; }
        public decimal? MaxCheckpointScn { get; set; }
        public decimal? RequiredCheckpointScn { get; set; }
        public string LogfileAssignment { get; set; }
        public DateTime? StatusChangeTime { get; set; }
        public decimal? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string Version { get; set; }
        public string CaptureType { get; set; }
        public decimal? LastEnqueuedScn { get; set; }
        public decimal? CheckpointRetentionTime { get; set; }
        public DateTime? StartTime { get; set; }
        public string Purpose { get; set; }
    }
}

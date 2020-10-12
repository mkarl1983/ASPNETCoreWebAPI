using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllChangeSets
    {
        public string SetName { get; set; }
        public string ChangeSourceName { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? BeginScn { get; set; }
        public decimal? EndScn { get; set; }
        public DateTime? FreshnessDate { get; set; }
        public decimal? FreshnessScn { get; set; }
        public string AdvanceEnabled { get; set; }
        public string IgnoreDdl { get; set; }
        public DateTime Created { get; set; }
        public string RollbackSegmentName { get; set; }
        public string Advancing { get; set; }
        public string Purging { get; set; }
        public decimal? LowestScn { get; set; }
        public string Tablespace { get; set; }
        public string CaptureEnabled { get; set; }
        public string StopOnDdl { get; set; }
        public string CaptureError { get; set; }
        public string CaptureName { get; set; }
        public string QueueName { get; set; }
        public string QueueTableName { get; set; }
        public string ApplyName { get; set; }
        public string SetDescription { get; set; }
        public string Publisher { get; set; }
        public DateTime? LowestTimestamp { get; set; }
        public string MapName { get; set; }
    }
}

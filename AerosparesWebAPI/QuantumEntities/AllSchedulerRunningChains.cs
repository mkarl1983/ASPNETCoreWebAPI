using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerRunningChains
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string JobSubname { get; set; }
        public string ChainOwner { get; set; }
        public string ChainName { get; set; }
        public string StepName { get; set; }
        public string State { get; set; }
        public decimal? ErrorCode { get; set; }
        public string Completed { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public TimeSpan? Duration { get; set; }
        public string Skip { get; set; }
        public string Pause { get; set; }
        public string PauseBefore { get; set; }
        public string RestartOnRecovery { get; set; }
        public string RestartOnFailure { get; set; }
        public string StepJobSubname { get; set; }
        public decimal? StepJobLogId { get; set; }
    }
}

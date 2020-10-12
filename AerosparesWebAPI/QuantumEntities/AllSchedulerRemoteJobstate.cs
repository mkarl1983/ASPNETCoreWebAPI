using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerRemoteJobstate
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string Destination { get; set; }
        public string State { get; set; }
        public DateTimeOffset? NextStartDate { get; set; }
        public decimal? RunCount { get; set; }
        public decimal? FailureCount { get; set; }
        public decimal? RetryCount { get; set; }
        public DateTimeOffset? LastStartDate { get; set; }
        public DateTimeOffset? LastEndDate { get; set; }
    }
}

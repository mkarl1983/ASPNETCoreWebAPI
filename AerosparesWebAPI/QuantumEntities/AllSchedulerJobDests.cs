using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerJobDests
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string JobSubname { get; set; }
        public string CredentialOwner { get; set; }
        public string CredentialName { get; set; }
        public string DestinationOwner { get; set; }
        public string Destination { get; set; }
        public decimal? JobDestId { get; set; }
        public string Enabled { get; set; }
        public string RefsEnabled { get; set; }
        public string State { get; set; }
        public DateTimeOffset? NextStartDate { get; set; }
        public decimal? RunCount { get; set; }
        public decimal? RetryCount { get; set; }
        public decimal? FailureCount { get; set; }
        public DateTimeOffset? LastStartDate { get; set; }
        public DateTimeOffset? LastEndDate { get; set; }
    }
}

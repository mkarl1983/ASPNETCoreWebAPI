using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerRunningJobs
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string JobSubname { get; set; }
        public string JobStyle { get; set; }
        public string Detached { get; set; }
        public decimal? SessionId { get; set; }
        public decimal? SlaveProcessId { get; set; }
        public string SlaveOsProcessId { get; set; }
        public decimal? RunningInstance { get; set; }
        public string ResourceConsumerGroup { get; set; }
        public TimeSpan? ElapsedTime { get; set; }
        public TimeSpan? CpuUsed { get; set; }
        public string DestinationOwner { get; set; }
        public string Destination { get; set; }
        public string CredentialOwner { get; set; }
        public string CredentialName { get; set; }
        public decimal? LogId { get; set; }
    }
}

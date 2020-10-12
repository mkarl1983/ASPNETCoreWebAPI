using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerJobRunDetails
    {
        public decimal? LogId { get; set; }
        public DateTimeOffset? LogDate { get; set; }
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string JobSubname { get; set; }
        public string Status { get; set; }
        public decimal? Error { get; set; }
        public DateTimeOffset? ReqStartDate { get; set; }
        public DateTimeOffset? ActualStartDate { get; set; }
        public TimeSpan? RunDuration { get; set; }
        public decimal? InstanceId { get; set; }
        public string SessionId { get; set; }
        public string SlavePid { get; set; }
        public TimeSpan? CpuUsed { get; set; }
        public string CredentialOwner { get; set; }
        public string CredentialName { get; set; }
        public string DestinationOwner { get; set; }
        public string Destination { get; set; }
        public string AdditionalInfo { get; set; }
    }
}

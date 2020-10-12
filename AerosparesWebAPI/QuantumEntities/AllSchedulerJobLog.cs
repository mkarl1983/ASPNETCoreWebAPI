using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerJobLog
    {
        public decimal LogId { get; set; }
        public DateTimeOffset? LogDate { get; set; }
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string JobSubname { get; set; }
        public string JobClass { get; set; }
        public string Operation { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string ClientId { get; set; }
        public string GlobalUid { get; set; }
        public string CredentialOwner { get; set; }
        public string CredentialName { get; set; }
        public string DestinationOwner { get; set; }
        public string Destination { get; set; }
        public string AdditionalInfo { get; set; }
    }
}

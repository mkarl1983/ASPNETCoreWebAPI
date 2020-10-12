using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXstreamOutbound
    {
        public string ServerName { get; set; }
        public string ConnectUser { get; set; }
        public string CaptureName { get; set; }
        public string SourceDatabase { get; set; }
        public string CaptureUser { get; set; }
        public string QueueOwner { get; set; }
        public string QueueName { get; set; }
        public string UserComment { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Status { get; set; }
        public string CommittedDataOnly { get; set; }
        public decimal? StartScn { get; set; }
        public DateTime? StartTime { get; set; }
    }
}

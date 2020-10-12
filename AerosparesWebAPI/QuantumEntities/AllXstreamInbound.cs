using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXstreamInbound
    {
        public string ServerName { get; set; }
        public string QueueOwner { get; set; }
        public string QueueName { get; set; }
        public string ApplyUser { get; set; }
        public string UserComment { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Status { get; set; }
        public string CommittedDataOnly { get; set; }
    }
}

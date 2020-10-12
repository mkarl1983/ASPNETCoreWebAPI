using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllQueues
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string QueueTable { get; set; }
        public decimal Qid { get; set; }
        public string QueueType { get; set; }
        public decimal? MaxRetries { get; set; }
        public decimal? RetryDelay { get; set; }
        public string EnqueueEnabled { get; set; }
        public string DequeueEnabled { get; set; }
        public string Retention { get; set; }
        public string UserComment { get; set; }
        public string NetworkName { get; set; }
    }
}

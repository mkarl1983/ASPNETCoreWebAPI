using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllQueueSubscribers
    {
        public string Owner { get; set; }
        public string QueueName { get; set; }
        public string QueueTable { get; set; }
        public string ConsumerName { get; set; }
        public string Address { get; set; }
        public decimal? Protocol { get; set; }
        public string Transformation { get; set; }
        public string Rule { get; set; }
        public string DeliveryMode { get; set; }
        public string IfNondurableSubscriber { get; set; }
        public string QueueToQueue { get; set; }
    }
}

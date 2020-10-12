using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllQueuePublishers
    {
        public string QueueOwner { get; set; }
        public string QueueName { get; set; }
        public string PublisherName { get; set; }
        public string PublisherAddress { get; set; }
        public decimal? PublisherProtocol { get; set; }
        public string PublisherRule { get; set; }
        public string PublisherRuleName { get; set; }
        public string PublisherRuleset { get; set; }
        public string PublisherTransformation { get; set; }
    }
}

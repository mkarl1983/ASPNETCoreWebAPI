using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqPublisher
    {
        public decimal PubId { get; set; }
        public decimal QueueId { get; set; }
        public string PName { get; set; }
        public string PAddress { get; set; }
        public decimal? PProtocol { get; set; }
        public string PRuleName { get; set; }
        public string PRule { get; set; }
        public string PRuleset { get; set; }
        public string PTransformation { get; set; }
    }
}

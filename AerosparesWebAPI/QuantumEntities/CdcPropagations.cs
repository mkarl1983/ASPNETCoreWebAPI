using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class CdcPropagations
    {
        public string PropagationName { get; set; }
        public string DestqueuePublisher { get; set; }
        public string DestqueueName { get; set; }
        public string StagingDatabase { get; set; }
        public string SourceidName { get; set; }
        public decimal SourceClass { get; set; }
    }
}

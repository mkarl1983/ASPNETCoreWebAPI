using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllChangePropagations
    {
        public string PropagationSourceName { get; set; }
        public string PropagationName { get; set; }
        public string StagingDatabase { get; set; }
        public string DestinationQueuePublisher { get; set; }
        public string DestinationQueue { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllChangePropagationSets
    {
        public string PropagationSourceName { get; set; }
        public string PropagationName { get; set; }
        public string StagingDatabase { get; set; }
        public string ChangeSetPublisher { get; set; }
        public string ChangeSetName { get; set; }
    }
}

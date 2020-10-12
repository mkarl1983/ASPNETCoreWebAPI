using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSyncCapture
    {
        public string CaptureName { get; set; }
        public string QueueName { get; set; }
        public string QueueOwner { get; set; }
        public string RuleSetName { get; set; }
        public string RuleSetOwner { get; set; }
        public string CaptureUser { get; set; }
    }
}

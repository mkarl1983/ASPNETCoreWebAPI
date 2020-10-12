using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyEnqueue
    {
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string DestinationQueueName { get; set; }
    }
}

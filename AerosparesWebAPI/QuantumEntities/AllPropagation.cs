using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllPropagation
    {
        public string PropagationName { get; set; }
        public string SourceQueueOwner { get; set; }
        public string SourceQueueName { get; set; }
        public string DestinationQueueOwner { get; set; }
        public string DestinationQueueName { get; set; }
        public string DestinationDblink { get; set; }
        public string RuleSetOwner { get; set; }
        public string RuleSetName { get; set; }
        public string NegativeRuleSetOwner { get; set; }
        public string NegativeRuleSetName { get; set; }
        public string QueueToQueue { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? ErrorDate { get; set; }
        public string OriginalPropagationName { get; set; }
        public string OriginalSourceQueueOwner { get; set; }
        public string OriginalSourceQueueName { get; set; }
        public decimal? AckedScn { get; set; }
        public decimal? AutoMergeThreshold { get; set; }
    }
}

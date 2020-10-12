using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqSchedulerRemdbJobqtabS
    {
        public decimal SubscriberId { get; set; }
        public string QueueName { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal? Protocol { get; set; }
        public decimal? SubscriberType { get; set; }
        public string RuleName { get; set; }
        public string TransName { get; set; }
        public string RulesetName { get; set; }
        public string NegativeRulesetName { get; set; }
        public DateTimeOffset? CreationTime { get; set; }
        public DateTimeOffset? ModificationTime { get; set; }
        public DateTimeOffset? DeletionTime { get; set; }
        public decimal? ScnAtRemove { get; set; }
        public decimal? ScnAtAdd { get; set; }
    }
}

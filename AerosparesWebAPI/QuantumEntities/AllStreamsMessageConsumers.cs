using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsMessageConsumers
    {
        public string StreamsName { get; set; }
        public string QueueName { get; set; }
        public string QueueOwner { get; set; }
        public string RuleSetName { get; set; }
        public string RuleSetOwner { get; set; }
        public string NegativeRuleSetName { get; set; }
        public string NegativeRuleSetOwner { get; set; }
        public string NotificationType { get; set; }
        public string NotificationAction { get; set; }
    }
}

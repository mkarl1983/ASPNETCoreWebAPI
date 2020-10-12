using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsMessageRules
    {
        public string StreamsName { get; set; }
        public string StreamsType { get; set; }
        public string MessageTypeName { get; set; }
        public string MessageTypeOwner { get; set; }
        public string MessageRuleVariable { get; set; }
        public string RuleName { get; set; }
        public string RuleOwner { get; set; }
        public string RuleCondition { get; set; }
    }
}

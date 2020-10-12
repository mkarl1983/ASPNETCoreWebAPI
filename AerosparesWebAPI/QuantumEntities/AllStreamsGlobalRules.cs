using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsGlobalRules
    {
        public string StreamsName { get; set; }
        public string StreamsType { get; set; }
        public string RuleType { get; set; }
        public string IncludeTaggedLcr { get; set; }
        public string SourceDatabase { get; set; }
        public string RuleName { get; set; }
        public string RuleOwner { get; set; }
        public string RuleCondition { get; set; }
    }
}

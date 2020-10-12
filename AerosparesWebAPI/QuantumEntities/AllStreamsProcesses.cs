using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsProcesses
    {
        public string StreamsType { get; set; }
        public string StreamsName { get; set; }
        public string RuleSetOwner { get; set; }
        public string RuleSetName { get; set; }
        public string NegativeRuleSetOwner { get; set; }
        public string NegativeRuleSetName { get; set; }
    }
}

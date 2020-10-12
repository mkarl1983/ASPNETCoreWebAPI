using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerChainRules
    {
        public string Owner { get; set; }
        public string ChainName { get; set; }
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string Condition { get; set; }
        public string Action { get; set; }
        public string Comments { get; set; }
    }
}

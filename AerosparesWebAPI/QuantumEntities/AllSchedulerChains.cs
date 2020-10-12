using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerChains
    {
        public string Owner { get; set; }
        public string ChainName { get; set; }
        public string RuleSetOwner { get; set; }
        public string RuleSetName { get; set; }
        public decimal? NumberOfRules { get; set; }
        public decimal? NumberOfSteps { get; set; }
        public string Enabled { get; set; }
        public TimeSpan? EvaluationInterval { get; set; }
        public string UserRuleSet { get; set; }
        public string Comments { get; set; }
    }
}

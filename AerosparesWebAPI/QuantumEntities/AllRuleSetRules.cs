using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRuleSetRules
    {
        public string RuleSetOwner { get; set; }
        public string RuleSetName { get; set; }
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string RuleSetRuleEnabled { get; set; }
        public string RuleSetRuleEvalCtxOwner { get; set; }
        public string RuleSetRuleEvalCtxName { get; set; }
        public string RuleSetRuleComment { get; set; }
    }
}

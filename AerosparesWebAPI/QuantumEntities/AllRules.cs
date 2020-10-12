using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRules
    {
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string RuleCondition { get; set; }
        public string RuleEvaluationContextOwner { get; set; }
        public string RuleEvaluationContextName { get; set; }
        public string RuleComment { get; set; }
    }
}

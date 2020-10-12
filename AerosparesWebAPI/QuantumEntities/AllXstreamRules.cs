using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXstreamRules
    {
        public string StreamsName { get; set; }
        public string StreamsType { get; set; }
        public string StreamsRuleType { get; set; }
        public string RuleSetOwner { get; set; }
        public string RuleSetName { get; set; }
        public string RuleSetType { get; set; }
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string RuleType { get; set; }
        public string RuleCondition { get; set; }
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public string IncludeTaggedLcr { get; set; }
        public string SubsettingOperation { get; set; }
        public string DmlCondition { get; set; }
        public string SourceDatabase { get; set; }
        public string OriginalRuleCondition { get; set; }
        public string SameRuleCondition { get; set; }
    }
}

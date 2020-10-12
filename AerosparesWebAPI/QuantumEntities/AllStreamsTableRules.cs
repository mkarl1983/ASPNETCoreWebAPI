using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsTableRules
    {
        public string StreamsName { get; set; }
        public string StreamsType { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string RuleType { get; set; }
        public string DmlCondition { get; set; }
        public string SubsettingOperation { get; set; }
        public string IncludeTaggedLcr { get; set; }
        public string SourceDatabase { get; set; }
        public string RuleName { get; set; }
        public string RuleOwner { get; set; }
        public string RuleCondition { get; set; }
    }
}

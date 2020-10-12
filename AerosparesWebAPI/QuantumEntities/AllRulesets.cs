using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRulesets
    {
        public string Owner { get; set; }
        public string RulesetName { get; set; }
        public string RulesetStorageTable { get; set; }
        public string BaseTable { get; set; }
        public string RulesetComment { get; set; }
    }
}

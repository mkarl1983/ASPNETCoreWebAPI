using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqSysServiceMetricsTabR
    {
        public string Queue { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal? Protocol { get; set; }
        public string Rule { get; set; }
        public string RuleSet { get; set; }
        public string Transformation { get; set; }
    }
}

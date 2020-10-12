using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepddl
    {
        public decimal? LogId { get; set; }
        public string Source { get; set; }
        public string Role { get; set; }
        public string Master { get; set; }
        public decimal? Line { get; set; }
        public string Text { get; set; }
        public decimal? DdlNum { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllAws
    {
        public string Owner { get; set; }
        public decimal AwNumber { get; set; }
        public string AwName { get; set; }
        public string AwVersion { get; set; }
        public decimal? Pagespaces { get; set; }
        public decimal? Generations { get; set; }
        public string Frozen { get; set; }
    }
}

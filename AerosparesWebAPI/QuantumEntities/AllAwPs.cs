using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllAwPs
    {
        public string Owner { get; set; }
        public decimal AwNumber { get; set; }
        public string AwName { get; set; }
        public int? Psnumber { get; set; }
        public decimal? Generations { get; set; }
        public decimal? Maxpages { get; set; }
    }
}

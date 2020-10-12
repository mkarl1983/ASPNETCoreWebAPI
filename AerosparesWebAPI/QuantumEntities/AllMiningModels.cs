using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMiningModels
    {
        public string Owner { get; set; }
        public string ModelName { get; set; }
        public string MiningFunction { get; set; }
        public string Algorithm { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal? BuildDuration { get; set; }
        public decimal? ModelSize { get; set; }
        public string Comments { get; set; }
    }
}

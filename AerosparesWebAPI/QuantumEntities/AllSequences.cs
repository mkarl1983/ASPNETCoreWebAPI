using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSequences
    {
        public string SequenceOwner { get; set; }
        public string SequenceName { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
        public decimal IncrementBy { get; set; }
        public string CycleFlag { get; set; }
        public string OrderFlag { get; set; }
        public decimal CacheSize { get; set; }
        public decimal LastNumber { get; set; }
    }
}

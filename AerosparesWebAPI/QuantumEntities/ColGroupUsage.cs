using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ColGroupUsage
    {
        public decimal Obj { get; set; }
        public string Cols { get; set; }
        public DateTime? Timestamp { get; set; }
        public decimal? Flags { get; set; }
    }
}

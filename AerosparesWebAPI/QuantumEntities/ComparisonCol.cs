using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ComparisonCol
    {
        public decimal ComparisonId { get; set; }
        public decimal ColPosition { get; set; }
        public string ColName { get; set; }
        public decimal? DataType { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public string Spare4 { get; set; }
    }
}

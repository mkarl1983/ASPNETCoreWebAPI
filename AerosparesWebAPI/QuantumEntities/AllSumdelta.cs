using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSumdelta
    {
        public decimal Tableobj { get; set; }
        public decimal Partitionobj { get; set; }
        public string Dmloperation { get; set; }
        public decimal Scn { get; set; }
        public DateTime Timestamp { get; set; }
        public string Lowrowid { get; set; }
        public string Highrowid { get; set; }
        public decimal? Sequence { get; set; }
        public decimal? Xid { get; set; }
    }
}

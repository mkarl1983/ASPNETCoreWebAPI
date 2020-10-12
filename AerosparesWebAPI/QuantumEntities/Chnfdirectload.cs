using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Chnfdirectload
    {
        public decimal Tableobj { get; set; }
        public decimal Partitionobj { get; set; }
        public decimal? Dmloperation { get; set; }
        public decimal Scn { get; set; }
        public string Lowrowid { get; set; }
        public string Highrowid { get; set; }
        public byte[] Xid { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
        public DateTime? Spare4 { get; set; }
    }
}

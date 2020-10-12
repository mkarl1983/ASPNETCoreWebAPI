using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AwPrg
    {
        public decimal? Awseq { get; set; }
        public decimal? Oid { get; set; }
        public int? Gen { get; set; }
        public decimal? Stm { get; set; }
        public byte[] Stmtext { get; set; }
        public byte[] Compcode { get; set; }
        public decimal? Flags { get; set; }
        public byte[] Spare { get; set; }
    }
}

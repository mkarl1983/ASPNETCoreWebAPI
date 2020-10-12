using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Aw
    {
        public string Awname { get; set; }
        public decimal Owner { get; set; }
        public decimal Awseq { get; set; }
        public decimal? Version { get; set; }
        public int? Oids { get; set; }
        public int? Objs { get; set; }
        public byte[] Dict { get; set; }
        public decimal? Rsygen { get; set; }
    }
}

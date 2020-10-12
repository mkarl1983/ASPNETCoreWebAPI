using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Compression
    {
        public decimal? Ts { get; set; }
        public decimal? File { get; set; }
        public decimal? Block { get; set; }
        public decimal Obj { get; set; }
        public decimal? Dataobj { get; set; }
        public decimal Ulevel { get; set; }
        public decimal? Sublevel { get; set; }
        public decimal? Ilevel { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Bestsortcol { get; set; }
        public decimal? Tinsize { get; set; }
        public decimal? Ctinsize { get; set; }
        public decimal? Toutsize { get; set; }
        public decimal? Cmpsize { get; set; }
        public decimal? Uncmpsize { get; set; }
        public DateTime? Mtime { get; set; }
        public byte[] Analyzer { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public decimal? Spare4 { get; set; }
    }
}

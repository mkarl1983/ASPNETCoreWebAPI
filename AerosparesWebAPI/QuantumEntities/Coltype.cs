using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Coltype
    {
        public decimal Obj { get; set; }
        public decimal Col { get; set; }
        public decimal Intcol { get; set; }
        public Guid Toid { get; set; }
        public decimal Version { get; set; }
        public decimal Packed { get; set; }
        public decimal? Intcols { get; set; }
        public byte[] IntcolS1 { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Typidcol { get; set; }
        public decimal? Synobj { get; set; }
    }
}

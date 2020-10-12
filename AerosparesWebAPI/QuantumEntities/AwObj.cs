using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AwObj
    {
        public decimal? Awseq { get; set; }
        public decimal? Oid { get; set; }
        public string Objname { get; set; }
        public int? Gen { get; set; }
        public byte? Objtype { get; set; }
        public string Partname { get; set; }
        public byte[] Objdef { get; set; }
        public byte[] Objvalue { get; set; }
        public byte[] Compcode { get; set; }
    }
}

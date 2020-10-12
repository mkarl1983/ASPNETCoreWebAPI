using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AwProp
    {
        public decimal? Awseq { get; set; }
        public decimal? Oid { get; set; }
        public string Objname { get; set; }
        public int? Gen { get; set; }
        public string Propname { get; set; }
        public decimal? Proptype { get; set; }
        public byte[] Propval { get; set; }
    }
}

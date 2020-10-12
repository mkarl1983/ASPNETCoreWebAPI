using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Col1
    {
        public string Tname { get; set; }
        public decimal Colno { get; set; }
        public string Cname { get; set; }
        public string Coltype { get; set; }
        public decimal Width { get; set; }
        public decimal? Scale { get; set; }
        public decimal? Precision { get; set; }
        public string Nulls { get; set; }
        public string Defaultval { get; set; }
        public string CharacterSetName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ChnfGroupFilterIot
    {
        public decimal Objectnum { get; set; }
        public string Exprfilter { get; set; }
        public string Exprlhs { get; set; }
        public decimal Colid { get; set; }
        public decimal Operator { get; set; }
        public byte[] Rhsval { get; set; }
        public decimal? Filterid { get; set; }
    }
}

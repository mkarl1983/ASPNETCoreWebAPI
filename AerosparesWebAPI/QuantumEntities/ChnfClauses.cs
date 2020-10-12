using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ChnfClauses
    {
        public decimal Clauseid { get; set; }
        public decimal? Objectnum { get; set; }
        public string Childlist { get; set; }
        public decimal? Clauseop { get; set; }
        public string Lhs { get; set; }
        public decimal? Predicateop { get; set; }
        public string Rhsval { get; set; }
        public decimal? Rhstype { get; set; }
        public decimal? Clauseflags { get; set; }
        public decimal? GlobalRefcount { get; set; }
        public byte[] Hashval { get; set; }
    }
}

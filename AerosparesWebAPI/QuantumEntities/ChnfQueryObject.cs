using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ChnfQueryObject
    {
        public decimal? Queryid { get; set; }
        public decimal? Objn { get; set; }
        public decimal? Flags { get; set; }
        public string Virtualclause { get; set; }
        public string SourceQuerySel { get; set; }
        public byte[] SourceQueryFropos { get; set; }
        public string SourceQueryWhr { get; set; }
        public byte[] Refcols { get; set; }
        public decimal? Position { get; set; }
        public decimal? Topclauseid { get; set; }
        public decimal? Joinclauseid { get; set; }
        public decimal? Maxdepth { get; set; }
    }
}

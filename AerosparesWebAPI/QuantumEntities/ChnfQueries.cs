using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ChnfQueries
    {
        public decimal? Queryid { get; set; }
        public decimal? Queryflags { get; set; }
        public string Selectlist { get; set; }
        public byte[] Fromlist { get; set; }
        public string Whereclause { get; set; }
        public byte[] Hashval { get; set; }
        public decimal? Scn { get; set; }
        public decimal? Userid { get; set; }
    }
}

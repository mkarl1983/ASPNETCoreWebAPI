using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ChnfQueryBinds
    {
        public decimal? Queryid { get; set; }
        public decimal? Querybindpos { get; set; }
        public string Querybindname { get; set; }
        public byte[] Querybindvalue { get; set; }
    }
}

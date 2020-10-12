using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepflavorObjects1
    {
        public decimal FlavorId { get; set; }
        public string Gname { get; set; }
        public string Sname { get; set; }
        public string Oname { get; set; }
        public decimal Type { get; set; }
        public byte[] ColumnsPresent { get; set; }
        public string Published { get; set; }
        public byte[] Flag { get; set; }
        public string Gowner { get; set; }
        public decimal? Version { get; set; }
        public byte[] Hashcode { get; set; }
    }
}

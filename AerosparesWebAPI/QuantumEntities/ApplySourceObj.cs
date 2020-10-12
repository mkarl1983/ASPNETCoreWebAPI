using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ApplySourceObj
    {
        public decimal Id { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal Type { get; set; }
        public string SourceDbName { get; set; }
        public string Dblink { get; set; }
        public decimal? InstScn { get; set; }
        public decimal? IgnoreScn { get; set; }
        public decimal? Spare1 { get; set; }
        public byte[] InstExternalPos { get; set; }
        public string Spare2 { get; set; }
        public byte[] Spare3 { get; set; }
    }
}

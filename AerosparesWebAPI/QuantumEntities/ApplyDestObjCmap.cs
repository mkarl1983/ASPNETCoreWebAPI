using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ApplyDestObjCmap
    {
        public decimal DestId { get; set; }
        public string SrcLongCname { get; set; }
        public string DestLongCname { get; set; }
        public decimal? Spare1 { get; set; }
    }
}

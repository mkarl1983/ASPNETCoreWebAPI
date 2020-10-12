using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviewAggregates
    {
        public string Owner { get; set; }
        public string MviewName { get; set; }
        public decimal PositionInSelect { get; set; }
        public string ContainerColumn { get; set; }
        public string AggFunction { get; set; }
        public string Distinctflag { get; set; }
        public string Measure { get; set; }
    }
}

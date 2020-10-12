using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSummaryKeys
    {
        public string Owner { get; set; }
        public string SummaryName { get; set; }
        public decimal PositionInSelect { get; set; }
        public string ContainerColumn { get; set; }
        public string DetailobjOwner { get; set; }
        public string DetailobjName { get; set; }
        public string DetailobjAlias { get; set; }
        public string DetailobjType { get; set; }
        public string DetailobjColumn { get; set; }
    }
}

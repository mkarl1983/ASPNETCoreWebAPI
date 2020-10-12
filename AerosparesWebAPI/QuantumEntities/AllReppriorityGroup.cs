using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllReppriorityGroup
    {
        public string Sname { get; set; }
        public string PriorityGroup { get; set; }
        public string DataType { get; set; }
        public decimal? FixedDataLength { get; set; }
        public string PriorityComment { get; set; }
        public string Gname { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepauditAttribute
    {
        public string Attribute { get; set; }
        public string DataType { get; set; }
        public decimal? DataLength { get; set; }
        public string Source { get; set; }
    }
}

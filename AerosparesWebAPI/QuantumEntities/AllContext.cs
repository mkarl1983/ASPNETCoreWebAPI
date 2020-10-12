using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllContext
    {
        public string Namespace { get; set; }
        public string Schema { get; set; }
        public string Package { get; set; }
    }
}

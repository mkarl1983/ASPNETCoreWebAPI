using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsUnsupported
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string Reason { get; set; }
        public string AutoFiltered { get; set; }
    }
}

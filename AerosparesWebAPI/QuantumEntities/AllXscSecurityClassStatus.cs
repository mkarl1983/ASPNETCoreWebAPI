using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXscSecurityClassStatus
    {
        public string ClassName { get; set; }
        public string TargetNamespace { get; set; }
        public string Enable { get; set; }
        public string DisabledByClassName { get; set; }
        public string DisabledByClassTargetNs { get; set; }
        public string Mutable { get; set; }
    }
}

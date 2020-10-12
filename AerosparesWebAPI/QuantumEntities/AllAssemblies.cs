using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllAssemblies
    {
        public string Owner { get; set; }
        public string AssemblyName { get; set; }
        public string FileSpec { get; set; }
        public string SecurityLevel { get; set; }
        public string Identity { get; set; }
        public string Status { get; set; }
    }
}

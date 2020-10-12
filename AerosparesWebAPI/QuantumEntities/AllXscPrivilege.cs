using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXscPrivilege
    {
        public string ClassName { get; set; }
        public string TargetNamespace { get; set; }
        public string PrivilegeName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

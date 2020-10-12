using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyHandleCollisions
    {
        public string ApplyName { get; set; }
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string SourceObjectOwner { get; set; }
        public string SourceObjectName { get; set; }
        public string Enabled { get; set; }
    }
}

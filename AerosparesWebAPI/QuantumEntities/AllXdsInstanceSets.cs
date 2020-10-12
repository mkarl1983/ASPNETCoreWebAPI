using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXdsInstanceSets
    {
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public string InstanceSet { get; set; }
        public string Description { get; set; }
        public string Static { get; set; }
        public string EvalRule { get; set; }
        public string AclFile { get; set; }
        public string AclLocation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllExternalTables
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string TypeOwner { get; set; }
        public string TypeName { get; set; }
        public string DefaultDirectoryOwner { get; set; }
        public string DefaultDirectoryName { get; set; }
        public string RejectLimit { get; set; }
        public string AccessType { get; set; }
        public string AccessParameters { get; set; }
        public string Property { get; set; }
    }
}

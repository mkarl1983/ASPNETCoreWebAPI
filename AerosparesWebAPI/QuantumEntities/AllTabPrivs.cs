using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabPrivs
    {
        public string Grantor { get; set; }
        public string Grantee { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string Privilege { get; set; }
        public string Grantable { get; set; }
        public string Hierarchy { get; set; }
    }
}

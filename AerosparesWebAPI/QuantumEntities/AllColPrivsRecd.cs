using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllColPrivsRecd
    {
        public string Grantee { get; set; }
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Grantor { get; set; }
        public string Privilege { get; set; }
        public string Grantable { get; set; }
    }
}

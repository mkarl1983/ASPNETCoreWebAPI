using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ColumnPrivileges
    {
        public string Grantee { get; set; }
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Grantor { get; set; }
        public string InsertPriv { get; set; }
        public string UpdatePriv { get; set; }
        public string ReferencesPriv { get; set; }
        public string Created { get; set; }
    }
}

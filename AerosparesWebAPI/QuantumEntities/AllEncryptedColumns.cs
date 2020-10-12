using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllEncryptedColumns
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string EncryptionAlg { get; set; }
        public string Salt { get; set; }
        public string IntegrityAlg { get; set; }
    }
}

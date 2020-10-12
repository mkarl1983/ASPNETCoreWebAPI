using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllNestedTables
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string TableTypeOwner { get; set; }
        public string TableTypeName { get; set; }
        public string ParentTableName { get; set; }
        public string ParentTableColumn { get; set; }
        public string StorageSpec { get; set; }
        public string ReturnType { get; set; }
        public string ElementSubstitutable { get; set; }
    }
}

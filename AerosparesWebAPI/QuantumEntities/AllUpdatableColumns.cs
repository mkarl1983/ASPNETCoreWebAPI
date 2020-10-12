using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllUpdatableColumns
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string Updatable { get; set; }
        public string Insertable { get; set; }
        public string Deletable { get; set; }
    }
}

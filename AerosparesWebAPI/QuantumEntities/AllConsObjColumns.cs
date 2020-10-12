using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllConsObjColumns
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ConsTypeOwner { get; set; }
        public string ConsTypeName { get; set; }
        public string ConsTypeOnly { get; set; }
    }
}

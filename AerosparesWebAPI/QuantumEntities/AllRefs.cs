using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRefs
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string WithRowid { get; set; }
        public string IsScoped { get; set; }
        public string ScopeTableOwner { get; set; }
        public string ScopeTableName { get; set; }
        public string ObjectIdType { get; set; }
    }
}

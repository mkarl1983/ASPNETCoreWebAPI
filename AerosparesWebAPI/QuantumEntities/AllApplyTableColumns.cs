using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyTableColumns
    {
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string ColumnName { get; set; }
        public string CompareOldOnDelete { get; set; }
        public string CompareOldOnUpdate { get; set; }
        public string ApplyDatabaseLink { get; set; }
    }
}

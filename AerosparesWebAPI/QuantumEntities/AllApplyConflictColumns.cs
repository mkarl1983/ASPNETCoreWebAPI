using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyConflictColumns
    {
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string MethodName { get; set; }
        public string ResolutionColumn { get; set; }
        public string ColumnName { get; set; }
        public string ApplyDatabaseLink { get; set; }
    }
}

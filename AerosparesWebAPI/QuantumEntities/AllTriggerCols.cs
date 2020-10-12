using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTriggerCols
    {
        public string TriggerOwner { get; set; }
        public string TriggerName { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnList { get; set; }
        public string ColumnUsage { get; set; }
    }
}

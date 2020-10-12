using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllLogGroupColumns
    {
        public string Owner { get; set; }
        public string LogGroupName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public decimal? Position { get; set; }
        public string LoggingProperty { get; set; }
    }
}

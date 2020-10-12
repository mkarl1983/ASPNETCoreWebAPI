using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabHistgrmPendingStats
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public string SubpartitionName { get; set; }
        public string ColumnName { get; set; }
        public decimal? EndpointNumber { get; set; }
        public decimal? EndpointValue { get; set; }
        public string EndpointActualValue { get; set; }
    }
}

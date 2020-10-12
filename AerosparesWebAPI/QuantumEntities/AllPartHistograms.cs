using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllPartHistograms
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public string ColumnName { get; set; }
        public decimal? BucketNumber { get; set; }
        public decimal? EndpointValue { get; set; }
        public string EndpointActualValue { get; set; }
    }
}

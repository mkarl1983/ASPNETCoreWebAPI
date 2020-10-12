using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabModifications
    {
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string PartitionName { get; set; }
        public string SubpartitionName { get; set; }
        public decimal? Inserts { get; set; }
        public decimal? Updates { get; set; }
        public decimal? Deletes { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Truncated { get; set; }
        public decimal? DropSegments { get; set; }
    }
}

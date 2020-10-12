using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRefreshDependencies
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ParentObjectType { get; set; }
        public decimal? OldestRefreshScn { get; set; }
        public DateTime? OldestRefreshDate { get; set; }
    }
}

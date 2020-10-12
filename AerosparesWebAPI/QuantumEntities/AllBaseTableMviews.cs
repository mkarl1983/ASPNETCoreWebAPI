using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllBaseTableMviews
    {
        public string Owner { get; set; }
        public string Master { get; set; }
        public DateTime MviewLastRefreshTime { get; set; }
        public decimal? MviewId { get; set; }
    }
}

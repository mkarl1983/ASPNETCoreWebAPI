using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRegisteredSnapshots
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string SnapshotSite { get; set; }
        public string CanUseLog { get; set; }
        public string Updatable { get; set; }
        public string RefreshMethod { get; set; }
        public decimal? SnapshotId { get; set; }
        public string Version { get; set; }
        public string QueryTxt { get; set; }
    }
}

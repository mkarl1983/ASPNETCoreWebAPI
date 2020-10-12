using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSyncCapturePreparedTabs
    {
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public decimal Scn { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}

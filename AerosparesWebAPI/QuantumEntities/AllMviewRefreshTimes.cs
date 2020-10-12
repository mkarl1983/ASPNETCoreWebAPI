using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviewRefreshTimes
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string MasterOwner { get; set; }
        public string Master { get; set; }
        public DateTime? LastRefresh { get; set; }
    }
}

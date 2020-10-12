using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRegisteredMviews
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string MviewSite { get; set; }
        public string CanUseLog { get; set; }
        public string Updatable { get; set; }
        public string RefreshMethod { get; set; }
        public decimal? MviewId { get; set; }
        public string Version { get; set; }
        public string QueryTxt { get; set; }
    }
}

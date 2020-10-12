using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class CdcSubscribers
    {
        public string SubscriptionName { get; set; }
        public decimal Handle { get; set; }
        public string SetName { get; set; }
        public string Username { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
        public decimal EarliestScn { get; set; }
        public decimal LatestScn { get; set; }
        public string Description { get; set; }
        public DateTime? LastPurged { get; set; }
        public DateTime? LastExtended { get; set; }
        public string MvlInvalid { get; set; }
        public decimal? Reserved1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllServices
    {
        public decimal? ServiceId { get; set; }
        public string Name { get; set; }
        public decimal? NameHash { get; set; }
        public string NetworkName { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? CreationDateHash { get; set; }
        public string FailoverMethod { get; set; }
        public string FailoverType { get; set; }
        public int? FailoverRetries { get; set; }
        public int? FailoverDelay { get; set; }
        public decimal? MinCardinality { get; set; }
        public decimal? MaxCardinality { get; set; }
        public string Goal { get; set; }
        public string Dtp { get; set; }
        public string Enabled { get; set; }
        public string AqHaNotifications { get; set; }
        public string ClbGoal { get; set; }
        public string Edition { get; set; }
    }
}

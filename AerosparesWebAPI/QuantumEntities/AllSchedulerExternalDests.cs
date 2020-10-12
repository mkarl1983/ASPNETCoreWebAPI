using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerExternalDests
    {
        public string DestinationName { get; set; }
        public string Hostname { get; set; }
        public decimal? Port { get; set; }
        public string IpAddress { get; set; }
        public string Enabled { get; set; }
        public string Comments { get; set; }
    }
}

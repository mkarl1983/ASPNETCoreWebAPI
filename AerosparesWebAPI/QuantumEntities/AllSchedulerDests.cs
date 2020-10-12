using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerDests
    {
        public string Owner { get; set; }
        public string DestinationName { get; set; }
        public string DestinationType { get; set; }
        public string Enabled { get; set; }
        public string Comments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerDbDests
    {
        public string Owner { get; set; }
        public string DestinationName { get; set; }
        public string ConnectInfo { get; set; }
        public string Agent { get; set; }
        public string Enabled { get; set; }
        public string RefsEnabled { get; set; }
        public string Comments { get; set; }
    }
}

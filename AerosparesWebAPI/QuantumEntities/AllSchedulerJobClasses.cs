using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerJobClasses
    {
        public string JobClassName { get; set; }
        public string ResourceConsumerGroup { get; set; }
        public string Service { get; set; }
        public string LoggingLevel { get; set; }
        public decimal? LogHistory { get; set; }
        public string Comments { get; set; }
    }
}

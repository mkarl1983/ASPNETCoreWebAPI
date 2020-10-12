using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqPropagationStatus
    {
        public decimal QueueId { get; set; }
        public string Destination { get; set; }
        public decimal? Sequence { get; set; }
        public decimal? Status { get; set; }
        public string Txnid { get; set; }
        public decimal DestqueueId { get; set; }
        public decimal? Flags { get; set; }
    }
}

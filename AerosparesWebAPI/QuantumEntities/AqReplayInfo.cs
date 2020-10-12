using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqReplayInfo
    {
        public decimal Eventid { get; set; }
        public string Correlationid { get; set; }
        public decimal? Ack { get; set; }
    }
}

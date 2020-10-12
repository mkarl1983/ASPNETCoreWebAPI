using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXstreamOutboundProgress
    {
        public string ServerName { get; set; }
        public string SourceDatabase { get; set; }
        public byte[] ProcessedLowPosition { get; set; }
        public DateTime? ProcessedLowTime { get; set; }
        public byte[] OldestPosition { get; set; }
    }
}

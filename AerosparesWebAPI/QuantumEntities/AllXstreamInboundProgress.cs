using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXstreamInboundProgress
    {
        public string ServerName { get; set; }
        public byte[] ProcessedLowPosition { get; set; }
        public byte[] AppliedLowPosition { get; set; }
        public byte[] AppliedHighPosition { get; set; }
        public byte[] SpillPosition { get; set; }
        public byte[] OldestPosition { get; set; }
        public decimal OldestMessageNumber { get; set; }
        public decimal AppliedMessageNumber { get; set; }
        public DateTime? AppliedTime { get; set; }
        public DateTime? AppliedMessageCreateTime { get; set; }
        public decimal? SpillMessageNumber { get; set; }
        public string SourceDatabase { get; set; }
    }
}

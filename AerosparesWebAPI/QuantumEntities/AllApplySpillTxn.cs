using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplySpillTxn
    {
        public string ApplyName { get; set; }
        public decimal Xidusn { get; set; }
        public decimal Xidslt { get; set; }
        public decimal Xidsqn { get; set; }
        public decimal FirstScn { get; set; }
        public decimal? MessageCount { get; set; }
        public DateTime? FirstMessageCreateTime { get; set; }
        public DateTime? SpillCreationTime { get; set; }
        public byte[] FirstPosition { get; set; }
        public string TransactionId { get; set; }
    }
}

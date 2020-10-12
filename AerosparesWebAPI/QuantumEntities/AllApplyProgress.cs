using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyProgress
    {
        public string ApplyName { get; set; }
        public string SourceDatabase { get; set; }
        public decimal AppliedMessageNumber { get; set; }
        public decimal OldestMessageNumber { get; set; }
        public DateTime? ApplyTime { get; set; }
        public DateTime? AppliedMessageCreateTime { get; set; }
        public string OldestTransactionId { get; set; }
        public decimal? SpillMessageNumber { get; set; }
    }
}

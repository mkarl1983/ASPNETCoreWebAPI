using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyError
    {
        public string ApplyName { get; set; }
        public string QueueName { get; set; }
        public string QueueOwner { get; set; }
        public string LocalTransactionId { get; set; }
        public string SourceDatabase { get; set; }
        public string SourceTransactionId { get; set; }
        public decimal? SourceCommitScn { get; set; }
        public decimal? MessageNumber { get; set; }
        public decimal? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public decimal? RecipientId { get; set; }
        public string RecipientName { get; set; }
        public decimal? MessageCount { get; set; }
        public DateTime? ErrorCreationTime { get; set; }
        public byte[] SourceCommitPosition { get; set; }
        public string ErrorType { get; set; }
    }
}

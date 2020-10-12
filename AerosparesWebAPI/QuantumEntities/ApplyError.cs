using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ApplyError
    {
        public string LocalTransactionId { get; set; }
        public string SourceTransactionId { get; set; }
        public string SourceDatabase { get; set; }
        public string QueueOwner { get; set; }
        public string QueueName { get; set; }
        public decimal Apply { get; set; }
        public decimal? MessageNumber { get; set; }
        public decimal? MessageCount { get; set; }
        public decimal? MinStepNo { get; set; }
        public decimal? RecipientId { get; set; }
        public string RecipientName { get; set; }
        public decimal? SourceCommitScn { get; set; }
        public decimal? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string AqTransactionId { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public DateTime? ErrorCreationTime { get; set; }
        public byte[] ExternalSourcePos { get; set; }
        public byte[] Spare4 { get; set; }
        public string Spare5 { get; set; }
        public decimal? CommitTime { get; set; }
        public decimal? Xidusn { get; set; }
        public decimal? Xidslt { get; set; }
        public decimal? Xidsqn { get; set; }
        public decimal? RetryCount { get; set; }
        public decimal? Flags { get; set; }
    }
}

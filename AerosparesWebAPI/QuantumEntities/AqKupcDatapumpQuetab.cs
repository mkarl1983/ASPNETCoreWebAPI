using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqKupcDatapumpQuetab
    {
        public string Queue { get; set; }
        public Guid MsgId { get; set; }
        public string CorrId { get; set; }
        public decimal? MsgPriority { get; set; }
        public string MsgState { get; set; }
        public DateTime? Delay { get; set; }
        public DateTime? DelayTimestamp { get; set; }
        public decimal? Expiration { get; set; }
        public DateTime? EnqTime { get; set; }
        public DateTime? EnqTimestamp { get; set; }
        public decimal? EnqUserId { get; set; }
        public string EnqTxnId { get; set; }
        public DateTime? DeqTime { get; set; }
        public DateTime? DeqTimestamp { get; set; }
        public decimal? DeqUserId { get; set; }
        public string DeqTxnId { get; set; }
        public decimal? RetryCount { get; set; }
        public string ExceptionQueueOwner { get; set; }
        public string ExceptionQueue { get; set; }
        public Guid? PropagatedMsgid { get; set; }
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public decimal? SenderProtocol { get; set; }
        public Guid? OriginalMsgid { get; set; }
        public string OriginalQueueName { get; set; }
        public string OriginalQueueOwner { get; set; }
        public string ExpirationReason { get; set; }
        public string ConsumerName { get; set; }
        public string Address { get; set; }
        public decimal? Protocol { get; set; }
    }
}

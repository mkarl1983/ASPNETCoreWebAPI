using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqSchedulerFilewatcherQtH
    {
        public Guid Msgid { get; set; }
        public decimal Subscriber { get; set; }
        public string Name { get; set; }
        public decimal Address { get; set; }
        public DateTime? DequeueTime { get; set; }
        public string TransactionId { get; set; }
        public string DequeueUser { get; set; }
        public Guid? PropagatedMsgid { get; set; }
        public decimal? RetryCount { get; set; }
        public string Hint { get; set; }
        public Guid? Spare { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqAlertQtL
    {
        public Guid? Msgid { get; set; }
        public decimal? Subscriber { get; set; }
        public string Name { get; set; }
        public decimal? Address { get; set; }
        public DateTimeOffset? DequeueTime { get; set; }
        public string TransactionId { get; set; }
        public string DequeueUser { get; set; }
        public byte[] Flags { get; set; }
    }
}

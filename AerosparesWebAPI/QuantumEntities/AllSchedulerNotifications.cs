using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerNotifications
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string JobSubname { get; set; }
        public string Recipient { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string FilterCondition { get; set; }
        public string Event { get; set; }
        public decimal EventFlag { get; set; }
    }
}

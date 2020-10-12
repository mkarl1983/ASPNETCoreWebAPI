using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerWindowLog
    {
        public decimal LogId { get; set; }
        public DateTimeOffset? LogDate { get; set; }
        public string WindowName { get; set; }
        public string Operation { get; set; }
        public string Status { get; set; }
        public string UserName { get; set; }
        public string ClientId { get; set; }
        public string GlobalUid { get; set; }
        public string AdditionalInfo { get; set; }
    }
}

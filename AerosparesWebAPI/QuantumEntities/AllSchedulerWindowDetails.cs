using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerWindowDetails
    {
        public decimal? LogId { get; set; }
        public DateTimeOffset? LogDate { get; set; }
        public string WindowName { get; set; }
        public DateTimeOffset? ReqStartDate { get; set; }
        public DateTimeOffset? ActualStartDate { get; set; }
        public TimeSpan? WindowDuration { get; set; }
        public TimeSpan? ActualDuration { get; set; }
        public decimal? InstanceId { get; set; }
        public string AdditionalInfo { get; set; }
    }
}

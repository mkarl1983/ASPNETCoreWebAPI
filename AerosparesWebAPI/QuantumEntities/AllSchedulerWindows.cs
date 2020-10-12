using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerWindows
    {
        public string WindowName { get; set; }
        public string ResourcePlan { get; set; }
        public string ScheduleOwner { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleType { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public string RepeatInterval { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public TimeSpan? Duration { get; set; }
        public string WindowPriority { get; set; }
        public DateTimeOffset? NextStartDate { get; set; }
        public DateTimeOffset? LastStartDate { get; set; }
        public string Enabled { get; set; }
        public string Active { get; set; }
        public DateTimeOffset? ManualOpenTime { get; set; }
        public TimeSpan? ManualDuration { get; set; }
        public string Comments { get; set; }
    }
}

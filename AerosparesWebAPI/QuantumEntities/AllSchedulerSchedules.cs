using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerSchedules
    {
        public string Owner { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleType { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public string RepeatInterval { get; set; }
        public string EventQueueOwner { get; set; }
        public string EventQueueName { get; set; }
        public string EventQueueAgent { get; set; }
        public string EventCondition { get; set; }
        public string FileWatcherOwner { get; set; }
        public string FileWatcherName { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string Comments { get; set; }
    }
}

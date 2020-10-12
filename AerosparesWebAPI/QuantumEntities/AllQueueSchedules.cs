using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllQueueSchedules
    {
        public string Schema { get; set; }
        public string Qname { get; set; }
        public string Destination { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public string StartTime { get; set; }
        public decimal? PropagationWindow { get; set; }
        public string NextTime { get; set; }
        public decimal? Latency { get; set; }
        public string ScheduleDisabled { get; set; }
        public string ProcessName { get; set; }
        public string SessionId { get; set; }
        public decimal? Instance { get; set; }
        public DateTimeOffset? LastRunDate { get; set; }
        public string LastRunTime { get; set; }
        public DateTimeOffset? CurrentStartDate { get; set; }
        public string CurrentStartTime { get; set; }
        public DateTimeOffset? NextRunDate { get; set; }
        public string NextRunTime { get; set; }
        public decimal? TotalTime { get; set; }
        public decimal? TotalNumber { get; set; }
        public decimal? TotalBytes { get; set; }
        public decimal? MaxNumber { get; set; }
        public decimal? MaxBytes { get; set; }
        public decimal? AvgNumber { get; set; }
        public decimal? AvgSize { get; set; }
        public decimal? AvgTime { get; set; }
        public decimal? Failures { get; set; }
        public DateTime? LastErrorDate { get; set; }
        public string LastErrorTime { get; set; }
        public string LastErrorMsg { get; set; }
        public string MessageDeliveryMode { get; set; }
        public decimal? ElapsedDequeueTime { get; set; }
        public decimal? ElapsedPickleTime { get; set; }
        public string JobName { get; set; }
    }
}

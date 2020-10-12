using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqSchedules
    {
        public Guid Oid { get; set; }
        public string Destination { get; set; }
        public DateTime? StartTime { get; set; }
        public string Duration { get; set; }
        public string NextTime { get; set; }
        public string Latency { get; set; }
        public DateTime? LastRun { get; set; }
        public decimal? Jobno { get; set; }
        public decimal? Failures { get; set; }
        public string Disabled { get; set; }
        public DateTime? ErrorTime { get; set; }
        public string LastErrorMsg { get; set; }
        public DateTime? CurStartTime { get; set; }
        public DateTime? NextRun { get; set; }
        public string ProcessName { get; set; }
        public decimal? Sid { get; set; }
        public decimal? Serial { get; set; }
        public decimal? TotalTime { get; set; }
        public decimal? TotalMsgs { get; set; }
        public decimal? TotalBytes { get; set; }
        public decimal? TotalWindows { get; set; }
        public decimal? WinMsgs { get; set; }
        public decimal? WinBytes { get; set; }
        public decimal? MaxNumPerWin { get; set; }
        public decimal? MaxSize { get; set; }
        public decimal? Instance { get; set; }
        public decimal? Spare1 { get; set; }
        public string Spare2 { get; set; }
        public string JobName { get; set; }
        public decimal? Destq { get; set; }
    }
}

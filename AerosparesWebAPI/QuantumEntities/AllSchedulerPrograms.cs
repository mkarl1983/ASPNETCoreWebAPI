using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerPrograms
    {
        public string Owner { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string ProgramAction { get; set; }
        public decimal? NumberOfArguments { get; set; }
        public string Enabled { get; set; }
        public string Detached { get; set; }
        public TimeSpan? ScheduleLimit { get; set; }
        public decimal? Priority { get; set; }
        public decimal? Weight { get; set; }
        public decimal? MaxRuns { get; set; }
        public decimal? MaxFailures { get; set; }
        public TimeSpan? MaxRunDuration { get; set; }
        public string NlsEnv { get; set; }
        public string Comments { get; set; }
    }
}

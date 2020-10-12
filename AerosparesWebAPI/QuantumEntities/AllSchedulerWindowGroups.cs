using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerWindowGroups
    {
        public string WindowGroupName { get; set; }
        public string Enabled { get; set; }
        public decimal? NumberOfWindows { get; set; }
        public string NextStartDate { get; set; }
        public string Comments { get; set; }
    }
}

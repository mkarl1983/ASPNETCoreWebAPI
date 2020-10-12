using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerGroups
    {
        public string Owner { get; set; }
        public string GroupName { get; set; }
        public string GroupType { get; set; }
        public string Enabled { get; set; }
        public decimal? NumberOfMembers { get; set; }
        public string Comments { get; set; }
    }
}

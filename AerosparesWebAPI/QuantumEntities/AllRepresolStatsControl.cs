using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepresolStatsControl
    {
        public string Sname { get; set; }
        public string Oname { get; set; }
        public DateTime Created { get; set; }
        public string Status { get; set; }
        public DateTime StatusUpdateDate { get; set; }
        public DateTime? PurgedDate { get; set; }
        public DateTime? LastPurgeStartDate { get; set; }
        public DateTime? LastPurgeEndDate { get; set; }
    }
}

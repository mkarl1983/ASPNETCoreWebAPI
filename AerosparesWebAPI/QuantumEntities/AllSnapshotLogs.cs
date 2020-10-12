using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSnapshotLogs
    {
        public string LogOwner { get; set; }
        public string Master { get; set; }
        public string LogTable { get; set; }
        public string LogTrigger { get; set; }
        public string Rowids { get; set; }
        public string PrimaryKey { get; set; }
        public string ObjectId { get; set; }
        public string FilterColumns { get; set; }
        public string Sequence { get; set; }
        public string IncludeNewValues { get; set; }
        public DateTime? CurrentSnapshots { get; set; }
        public decimal? SnapshotId { get; set; }
    }
}

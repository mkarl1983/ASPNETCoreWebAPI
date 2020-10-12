using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviewLogs
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
        public string PurgeAsynchronous { get; set; }
        public string PurgeDeferred { get; set; }
        public DateTime? PurgeStart { get; set; }
        public string PurgeInterval { get; set; }
        public DateTime? LastPurgeDate { get; set; }
        public decimal? LastPurgeStatus { get; set; }
        public decimal? NumRowsPurged { get; set; }
        public string CommitScnBased { get; set; }
    }
}

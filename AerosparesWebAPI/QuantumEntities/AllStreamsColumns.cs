using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsColumns
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public decimal? SyncCaptureVersion { get; set; }
        public string SyncCaptureReason { get; set; }
        public decimal? ApplyVersion { get; set; }
        public string ApplyReason { get; set; }
    }
}

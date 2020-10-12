using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSnapshots
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string TableName { get; set; }
        public string MasterView { get; set; }
        public string MasterOwner { get; set; }
        public string Master { get; set; }
        public string MasterLink { get; set; }
        public string CanUseLog { get; set; }
        public string Updatable { get; set; }
        public string RefreshMethod { get; set; }
        public DateTime? LastRefresh { get; set; }
        public decimal? Error { get; set; }
        public string FrOperations { get; set; }
        public string CrOperations { get; set; }
        public string Type { get; set; }
        public string Next { get; set; }
        public DateTime? StartWith { get; set; }
        public decimal? RefreshGroup { get; set; }
        public string UpdateTrig { get; set; }
        public string UpdateLog { get; set; }
        public string Query { get; set; }
        public string MasterRollbackSeg { get; set; }
        public string Status { get; set; }
        public string RefreshMode { get; set; }
        public string Prebuilt { get; set; }
    }
}

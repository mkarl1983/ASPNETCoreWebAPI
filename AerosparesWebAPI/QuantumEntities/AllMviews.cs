using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviews
    {
        public string Owner { get; set; }
        public string MviewName { get; set; }
        public string ContainerName { get; set; }
        public string Query { get; set; }
        public decimal? QueryLen { get; set; }
        public string Updatable { get; set; }
        public string UpdateLog { get; set; }
        public string MasterRollbackSeg { get; set; }
        public string MasterLink { get; set; }
        public string RewriteEnabled { get; set; }
        public string RewriteCapability { get; set; }
        public string RefreshMode { get; set; }
        public string RefreshMethod { get; set; }
        public string BuildMode { get; set; }
        public string FastRefreshable { get; set; }
        public string LastRefreshType { get; set; }
        public DateTime? LastRefreshDate { get; set; }
        public string Staleness { get; set; }
        public string AfterFastRefresh { get; set; }
        public string UnknownPrebuilt { get; set; }
        public string UnknownPlsqlFunc { get; set; }
        public string UnknownExternalTable { get; set; }
        public string UnknownConsiderFresh { get; set; }
        public string UnknownImport { get; set; }
        public string UnknownTrustedFd { get; set; }
        public string CompileState { get; set; }
        public string UseNoIndex { get; set; }
        public DateTime? StaleSince { get; set; }
        public decimal? NumPctTables { get; set; }
        public decimal? NumFreshPctRegions { get; set; }
        public decimal? NumStalePctRegions { get; set; }
    }
}

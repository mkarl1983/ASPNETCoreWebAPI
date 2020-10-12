using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviewAnalysis
    {
        public string Owner { get; set; }
        public string MviewName { get; set; }
        public string MviewTableOwner { get; set; }
        public string ContainerName { get; set; }
        public decimal? LastRefreshScn { get; set; }
        public DateTime? LastRefreshDate { get; set; }
        public string RefreshMethod { get; set; }
        public string Summary { get; set; }
        public decimal? Fullrefreshtim { get; set; }
        public decimal? Increfreshtim { get; set; }
        public string ContainsViews { get; set; }
        public string Unusable { get; set; }
        public string RestrictedSyntax { get; set; }
        public string IncRefreshable { get; set; }
        public string KnownStale { get; set; }
        public string Invalid { get; set; }
        public string RewriteEnabled { get; set; }
        public decimal? QueryLen { get; set; }
        public string Query { get; set; }
        public decimal Revision { get; set; }
    }
}

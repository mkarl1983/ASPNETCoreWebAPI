using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRefresh
    {
        public string Rowner { get; set; }
        public string Rname { get; set; }
        public decimal? Refgroup { get; set; }
        public string ImplicitDestroy { get; set; }
        public string PushDeferredRpc { get; set; }
        public string RefreshAfterErrors { get; set; }
        public string RollbackSeg { get; set; }
        public decimal? Job { get; set; }
        public DateTime? NextDate { get; set; }
        public string Interval { get; set; }
        public string Broken { get; set; }
        public decimal? PurgeOption { get; set; }
        public decimal? Parallelism { get; set; }
        public decimal? HeapSize { get; set; }
    }
}

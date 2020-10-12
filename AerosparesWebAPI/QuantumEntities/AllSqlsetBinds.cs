using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlsetBinds
    {
        public string SqlsetName { get; set; }
        public string SqlsetOwner { get; set; }
        public decimal? SqlsetId { get; set; }
        public string SqlId { get; set; }
        public decimal? ForceMatchingSignature { get; set; }
        public decimal? PlanHashValue { get; set; }
        public decimal? Position { get; set; }
        public string Captured { get; set; }
        public decimal? SqlSeq { get; set; }
    }
}

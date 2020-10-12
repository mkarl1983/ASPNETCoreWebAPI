using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlsetStatementsPhv
    {
        public string SqlsetName { get; set; }
        public string SqlsetOwner { get; set; }
        public decimal SqlsetId { get; set; }
        public string SqlId { get; set; }
        public decimal ForceMatchingSignature { get; set; }
        public decimal PlanHashValue { get; set; }
        public decimal? CommandType { get; set; }
        public string ParsingSchemaName { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public DateTime? PlanTimestamp { get; set; }
        public string BindsCaptured { get; set; }
        public decimal SqlSeq { get; set; }
    }
}

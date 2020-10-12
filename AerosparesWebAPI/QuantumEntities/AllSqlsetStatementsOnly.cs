using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlsetStatementsOnly
    {
        public string SqlsetName { get; set; }
        public string SqlsetOwner { get; set; }
        public decimal SqlsetId { get; set; }
        public string SqlId { get; set; }
        public decimal ForceMatchingSignature { get; set; }
        public decimal? CommandType { get; set; }
        public string ParsingSchemaName { get; set; }
        public string Module { get; set; }
        public string Action { get; set; }
        public decimal SqlSeq { get; set; }
    }
}

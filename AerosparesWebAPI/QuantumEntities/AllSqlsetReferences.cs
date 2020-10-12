using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlsetReferences
    {
        public string SqlsetName { get; set; }
        public string SqlsetOwner { get; set; }
        public decimal SqlsetId { get; set; }
        public decimal Id { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
    }
}

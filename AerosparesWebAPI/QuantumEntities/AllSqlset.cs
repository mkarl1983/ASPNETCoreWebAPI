using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqlset
    {
        public string Name { get; set; }
        public decimal Id { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }
        public decimal? StatementCount { get; set; }
    }
}

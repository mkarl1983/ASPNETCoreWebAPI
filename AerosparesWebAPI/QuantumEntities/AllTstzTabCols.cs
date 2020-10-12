using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTstzTabCols
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string QualifiedColName { get; set; }
        public decimal? Nested { get; set; }
    }
}

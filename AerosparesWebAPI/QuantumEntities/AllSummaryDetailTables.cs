using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSummaryDetailTables
    {
        public string Owner { get; set; }
        public string SummaryName { get; set; }
        public string DetailOwner { get; set; }
        public string DetailRelation { get; set; }
        public string DetailType { get; set; }
        public string DetailAlias { get; set; }
    }
}

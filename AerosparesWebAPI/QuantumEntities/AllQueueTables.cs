using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllQueueTables
    {
        public string Owner { get; set; }
        public string QueueTable { get; set; }
        public string Type { get; set; }
        public string ObjectType { get; set; }
        public string SortOrder { get; set; }
        public string Recipients { get; set; }
        public string MessageGrouping { get; set; }
        public string Compatible { get; set; }
        public decimal? PrimaryInstance { get; set; }
        public decimal? SecondaryInstance { get; set; }
        public decimal? OwnerInstance { get; set; }
        public string UserComment { get; set; }
        public string Secure { get; set; }
    }
}

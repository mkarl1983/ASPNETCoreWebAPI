using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXmlIndexes
    {
        public string IndexOwner { get; set; }
        public string IndexName { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string Type { get; set; }
        public string IndexType { get; set; }
        public string PathTableName { get; set; }
        public string Parameters { get; set; }
        public string Async { get; set; }
        public string Stale { get; set; }
        public string PendTableName { get; set; }
        public string ExOrInclude { get; set; }
    }
}

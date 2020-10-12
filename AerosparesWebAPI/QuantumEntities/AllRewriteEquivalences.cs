using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRewriteEquivalences
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string SourceStmt { get; set; }
        public string DestinationStmt { get; set; }
        public string RewriteMode { get; set; }
    }
}

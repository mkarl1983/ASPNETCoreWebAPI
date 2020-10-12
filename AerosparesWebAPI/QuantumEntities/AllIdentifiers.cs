using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIdentifiers
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Signature { get; set; }
        public string Type { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string Usage { get; set; }
        public decimal? UsageId { get; set; }
        public decimal? Line { get; set; }
        public decimal? Col { get; set; }
        public decimal? UsageContextId { get; set; }
    }
}

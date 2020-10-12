using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllWarningSettings
    {
        public string Owner { get; set; }
        public string ObjectName { get; set; }
        public decimal ObjectId { get; set; }
        public string ObjectType { get; set; }
        public string Warning { get; set; }
        public string Setting { get; set; }
    }
}

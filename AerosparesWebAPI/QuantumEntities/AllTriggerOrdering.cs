using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTriggerOrdering
    {
        public string TriggerOwner { get; set; }
        public string TriggerName { get; set; }
        public string ReferencedTriggerOwner { get; set; }
        public string ReferencedTriggerName { get; set; }
        public string OrderingType { get; set; }
    }
}

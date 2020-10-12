using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqSchedulerEventQtabG
    {
        public Guid Msgid { get; set; }
        public decimal Subscriber { get; set; }
        public string Name { get; set; }
        public decimal Address { get; set; }
    }
}

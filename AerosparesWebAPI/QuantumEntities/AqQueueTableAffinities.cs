using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqQueueTableAffinities
    {
        public decimal TableObjno { get; set; }
        public decimal PrimaryInstance { get; set; }
        public decimal SecondaryInstance { get; set; }
        public decimal OwnerInstance { get; set; }
    }
}

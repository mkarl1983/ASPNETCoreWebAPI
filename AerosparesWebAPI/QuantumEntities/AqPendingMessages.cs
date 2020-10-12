using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqPendingMessages
    {
        public decimal? Sequence { get; set; }
        public Guid? Msgid { get; set; }
        public decimal? Copy { get; set; }
        public Guid? Pmsgid { get; set; }
        public string Txnid { get; set; }
        public decimal? Flags { get; set; }
    }
}

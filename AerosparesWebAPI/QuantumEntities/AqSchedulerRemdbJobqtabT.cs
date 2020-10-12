using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqSchedulerRemdbJobqtabT
    {
        public DateTime NextDate { get; set; }
        public string TxnId { get; set; }
        public Guid Msgid { get; set; }
        public decimal? Action { get; set; }
    }
}

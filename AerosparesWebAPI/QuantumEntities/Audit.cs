using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Audit
    {
        public decimal User { get; set; }
        public decimal? Proxy { get; set; }
        public decimal Option { get; set; }
        public decimal? Success { get; set; }
        public decimal? Failure { get; set; }
    }
}

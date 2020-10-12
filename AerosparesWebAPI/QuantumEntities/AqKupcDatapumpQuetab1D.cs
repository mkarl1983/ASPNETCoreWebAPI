using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqKupcDatapumpQuetab1D
    {
        public decimal Qid { get; set; }
        public decimal Msgnum { get; set; }
        public Guid? Msgid { get; set; }
        public decimal Sub { get; set; }
        public decimal? Seqnum { get; set; }
    }
}

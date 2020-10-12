using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class BaseUser
    {
        public decimal User { get; set; }
        public decimal Type { get; set; }
        public decimal Datats { get; set; }
        public decimal Tempts { get; set; }
        public DateTime Ctime { get; set; }
        public DateTime? Ptime { get; set; }
        public DateTime? Exptime { get; set; }
        public DateTime? Ltime { get; set; }
        public decimal Resource { get; set; }
        public string Audit { get; set; }
        public decimal Defrole { get; set; }
        public decimal? Defgrp { get; set; }
        public decimal? DefgrpSeq { get; set; }
        public decimal Astatus { get; set; }
        public decimal Lcount { get; set; }
        public string Defschclass { get; set; }
        public string ExtUsername { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public DateTime? Spare6 { get; set; }
        public string Name { get; set; }
    }
}

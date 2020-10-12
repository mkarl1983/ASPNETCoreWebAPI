using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Clu
    {
        public decimal Obj { get; set; }
        public decimal? Dataobj { get; set; }
        public decimal Ts { get; set; }
        public decimal File { get; set; }
        public decimal Block { get; set; }
        public decimal Cols { get; set; }
        public decimal Pctfree { get; set; }
        public decimal Pctused { get; set; }
        public decimal Initrans { get; set; }
        public decimal Maxtrans { get; set; }
        public decimal? Size { get; set; }
        public string Hashfunc { get; set; }
        public decimal? Hashkeys { get; set; }
        public decimal? Func { get; set; }
        public decimal? Extind { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Degree { get; set; }
        public decimal? Instances { get; set; }
        public decimal? Avgchn { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public decimal? Spare4 { get; set; }
        public string Spare5 { get; set; }
        public string Spare6 { get; set; }
        public DateTime? Spare7 { get; set; }
    }
}

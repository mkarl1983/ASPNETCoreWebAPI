using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Collection
    {
        public Guid Toid { get; set; }
        public decimal Version { get; set; }
        public Guid CollToid { get; set; }
        public decimal CollVersion { get; set; }
        public Guid ElemToid { get; set; }
        public decimal ElemVersion { get; set; }
        public decimal? Synobj { get; set; }
        public decimal Properties { get; set; }
        public decimal? Charsetid { get; set; }
        public decimal? Charsetform { get; set; }
        public decimal? Length { get; set; }
        public decimal? Precision { get; set; }
        public decimal? Scale { get; set; }
        public decimal? UpperBound { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
    }
}

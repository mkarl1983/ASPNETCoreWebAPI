﻿using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Attribute
    {
        public Guid Toid { get; set; }
        public decimal Version { get; set; }
        public string Name { get; set; }
        public decimal Attribute1 { get; set; }
        public Guid AttrToid { get; set; }
        public decimal AttrVersion { get; set; }
        public decimal? Synobj { get; set; }
        public decimal Properties { get; set; }
        public decimal? Charsetid { get; set; }
        public decimal? Charsetform { get; set; }
        public decimal? Length { get; set; }
        public decimal? Precision { get; set; }
        public decimal? Scale { get; set; }
        public string Externname { get; set; }
        public decimal? Xflags { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public decimal? Spare4 { get; set; }
        public decimal? Spare5 { get; set; }
        public decimal? Setter { get; set; }
        public decimal? Getter { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Association
    {
        public decimal Obj { get; set; }
        public decimal Property { get; set; }
        public decimal? Intcol { get; set; }
        public decimal? Statstype { get; set; }
        public decimal? DefaultSelectivity { get; set; }
        public decimal? DefaultCpuCost { get; set; }
        public decimal? DefaultIoCost { get; set; }
        public decimal? DefaultNetCost { get; set; }
        public decimal? InterfaceVersion { get; set; }
        public decimal? Spare2 { get; set; }
    }
}

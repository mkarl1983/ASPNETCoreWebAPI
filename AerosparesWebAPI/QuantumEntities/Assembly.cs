using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Assembly
    {
        public decimal Obj { get; set; }
        public string Filespec { get; set; }
        public decimal? SecurityLevel { get; set; }
        public string Identity { get; set; }
        public decimal? Property { get; set; }
        public string Audit { get; set; }
    }
}

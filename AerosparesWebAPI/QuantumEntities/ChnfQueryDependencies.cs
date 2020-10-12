using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ChnfQueryDependencies
    {
        public decimal? Primarytype { get; set; }
        public decimal? Primaryid { get; set; }
        public decimal? Dependencytype { get; set; }
        public string Dependentname { get; set; }
    }
}

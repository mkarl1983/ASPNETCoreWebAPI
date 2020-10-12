using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ChnfClauseDependents
    {
        public decimal? Clauseid { get; set; }
        public decimal? Dependentid { get; set; }
        public decimal? Dependenttype { get; set; }
        public decimal? Refcount { get; set; }
    }
}

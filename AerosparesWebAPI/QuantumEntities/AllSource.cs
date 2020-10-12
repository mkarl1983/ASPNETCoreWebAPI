using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSource
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal? Line { get; set; }
        public string Text { get; set; }
    }
}

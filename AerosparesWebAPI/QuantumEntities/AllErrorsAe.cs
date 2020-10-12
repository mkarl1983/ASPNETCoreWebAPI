using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllErrorsAe
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Sequence { get; set; }
        public decimal Line { get; set; }
        public decimal Position { get; set; }
        public string Text { get; set; }
        public string Attribute { get; set; }
        public decimal? MessageNumber { get; set; }
        public string EditionName { get; set; }
    }
}

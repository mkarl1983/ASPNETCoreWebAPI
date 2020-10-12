using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIndextypeOperators
    {
        public string Owner { get; set; }
        public string IndextypeName { get; set; }
        public string OperatorSchema { get; set; }
        public string OperatorName { get; set; }
        public decimal Binding { get; set; }
    }
}

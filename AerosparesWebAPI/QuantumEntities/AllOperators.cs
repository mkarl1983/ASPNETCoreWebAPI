using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllOperators
    {
        public string Owner { get; set; }
        public string OperatorName { get; set; }
        public decimal NumberOfBinds { get; set; }
    }
}

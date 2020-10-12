using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllOparguments
    {
        public string Owner { get; set; }
        public string OperatorName { get; set; }
        public decimal Binding { get; set; }
        public decimal Position { get; set; }
        public string ArgumentType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllOpbindings
    {
        public string Owner { get; set; }
        public string OperatorName { get; set; }
        public decimal Binding { get; set; }
        public string FunctionName { get; set; }
        public string ReturnSchema { get; set; }
        public string ReturnType { get; set; }
        public string ImplementationTypeSchema { get; set; }
        public string ImplementationType { get; set; }
        public string Property { get; set; }
    }
}

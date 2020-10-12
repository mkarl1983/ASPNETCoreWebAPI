using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJavaThrows
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? MethodIndex { get; set; }
        public string MethodName { get; set; }
        public decimal? ExceptionIndex { get; set; }
        public string ExceptionClass { get; set; }
    }
}

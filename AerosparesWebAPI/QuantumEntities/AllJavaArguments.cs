using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJavaArguments
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? MethodIndex { get; set; }
        public string MethodName { get; set; }
        public decimal? ArgumentPosition { get; set; }
        public decimal? ArrayDepth { get; set; }
        public string BaseType { get; set; }
        public string ArgumentClass { get; set; }
    }
}

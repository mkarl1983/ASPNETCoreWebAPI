using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJavaMethods
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? MethodIndex { get; set; }
        public string MethodName { get; set; }
        public string Accessibility { get; set; }
        public string IsStatic { get; set; }
        public string IsFinal { get; set; }
        public string IsSynchronized { get; set; }
        public string IsNative { get; set; }
        public string IsAbstract { get; set; }
        public string IsStrict { get; set; }
        public decimal? Arguments { get; set; }
        public decimal? Throws { get; set; }
        public decimal? ArrayDepth { get; set; }
        public string BaseType { get; set; }
        public string ReturnClass { get; set; }
        public string IsCompiled { get; set; }
    }
}

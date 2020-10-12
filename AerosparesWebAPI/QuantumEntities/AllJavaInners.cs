using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJavaInners
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? InnerIndex { get; set; }
        public string SimpleName { get; set; }
        public string FullName { get; set; }
        public string Accessibility { get; set; }
        public string IsStatic { get; set; }
        public string IsFinal { get; set; }
        public string IsAbstract { get; set; }
        public string IsInterface { get; set; }
    }
}

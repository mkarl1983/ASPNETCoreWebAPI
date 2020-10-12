using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJavaClasses
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? Major { get; set; }
        public decimal? Minor { get; set; }
        public string Kind { get; set; }
        public string Accessibility { get; set; }
        public string IsInner { get; set; }
        public string IsAbstract { get; set; }
        public string IsFinal { get; set; }
        public string IsDebug { get; set; }
        public string Source { get; set; }
        public string Super { get; set; }
        public string Outer { get; set; }
    }
}

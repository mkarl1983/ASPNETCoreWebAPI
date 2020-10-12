using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJavaFields
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? FieldIndex { get; set; }
        public string FieldName { get; set; }
        public string Accessibility { get; set; }
        public string IsStatic { get; set; }
        public string IsFinal { get; set; }
        public string IsVolatile { get; set; }
        public string IsTransient { get; set; }
        public decimal? ArrayDepth { get; set; }
        public string BaseType { get; set; }
        public string FieldClass { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllAttributeTransformations
    {
        public decimal TransformationId { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string FromType { get; set; }
        public string ToType { get; set; }
        public decimal Attribute { get; set; }
        public string AttributeTransformation { get; set; }
    }
}

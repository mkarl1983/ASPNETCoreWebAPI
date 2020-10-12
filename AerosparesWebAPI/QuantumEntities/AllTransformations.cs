using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTransformations
    {
        public decimal TransformationId { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public string FromType { get; set; }
        public string ToType { get; set; }
    }
}

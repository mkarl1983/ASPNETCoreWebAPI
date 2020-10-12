using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AttributeTransformations
    {
        public decimal TransformationId { get; set; }
        public decimal AttributeNumber { get; set; }
        public string SqlExpression { get; set; }
        public string XslTransformation { get; set; }

        public virtual Transformations Transformation { get; set; }
    }
}

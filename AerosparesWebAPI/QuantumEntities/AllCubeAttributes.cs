using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubeAttributes
    {
        public string Owner { get; set; }
        public string DimensionName { get; set; }
        public string AttributeName { get; set; }
        public string TargetDimensionName { get; set; }
        public string AttributeRole { get; set; }
        public string Description { get; set; }
        public string DataType { get; set; }
        public decimal DataLength { get; set; }
        public decimal? DataPrecision { get; set; }
        public decimal? DataScale { get; set; }
    }
}

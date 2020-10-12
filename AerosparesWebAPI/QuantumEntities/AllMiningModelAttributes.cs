using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMiningModelAttributes
    {
        public string Owner { get; set; }
        public string ModelName { get; set; }
        public string AttributeName { get; set; }
        public string AttributeType { get; set; }
        public string DataType { get; set; }
        public decimal? DataLength { get; set; }
        public decimal? DataPrecision { get; set; }
        public decimal? DataScale { get; set; }
        public string UsageType { get; set; }
        public string Target { get; set; }
    }
}

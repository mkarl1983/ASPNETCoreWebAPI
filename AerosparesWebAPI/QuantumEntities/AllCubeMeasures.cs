using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCubeMeasures
    {
        public string Owner { get; set; }
        public string CubeName { get; set; }
        public string MeasureName { get; set; }
        public string OverrideSolveSpec { get; set; }
        public string MeasureType { get; set; }
        public string Expression { get; set; }
        public string Description { get; set; }
        public string DataType { get; set; }
        public decimal DataLength { get; set; }
        public decimal? DataPrecision { get; set; }
        public decimal? DataScale { get; set; }
    }
}

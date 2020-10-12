using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMeasureFolderContents
    {
        public string Owner { get; set; }
        public string MeasureFolderName { get; set; }
        public string CubeOwner { get; set; }
        public string CubeName { get; set; }
        public string MeasureName { get; set; }
        public decimal OrderNum { get; set; }
    }
}

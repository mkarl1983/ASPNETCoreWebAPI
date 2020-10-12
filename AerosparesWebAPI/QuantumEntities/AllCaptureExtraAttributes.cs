using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCaptureExtraAttributes
    {
        public string CaptureName { get; set; }
        public string AttributeName { get; set; }
        public string Include { get; set; }
        public string RowAttribute { get; set; }
        public string DdlAttribute { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCaptureParameters
    {
        public string CaptureName { get; set; }
        public string Parameter { get; set; }
        public string Value { get; set; }
        public string SetByUser { get; set; }
    }
}

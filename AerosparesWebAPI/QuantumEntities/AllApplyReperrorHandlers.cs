using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyReperrorHandlers
    {
        public string ApplyName { get; set; }
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string SourceObjectOwner { get; set; }
        public string SourceObjectName { get; set; }
        public decimal ErrorNumber { get; set; }
        public string Method { get; set; }
        public decimal? MaxRetries { get; set; }
        public decimal? DelayCsecs { get; set; }
    }
}

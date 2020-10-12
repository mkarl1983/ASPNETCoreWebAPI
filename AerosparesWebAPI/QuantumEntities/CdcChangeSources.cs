using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class CdcChangeSources
    {
        public string SourceName { get; set; }
        public decimal? Dbid { get; set; }
        public string LogfileLocation { get; set; }
        public string LogfileSuffix { get; set; }
        public string SourceDescription { get; set; }
        public DateTime Created { get; set; }
        public decimal SourceType { get; set; }
        public string SourceDatabase { get; set; }
        public string SourceDbid { get; set; }
        public decimal? FirstScn { get; set; }
        public string FirstLogfile { get; set; }
        public string LogfileFormat { get; set; }
        public string Publisher { get; set; }
        public string CaptureName { get; set; }
        public string CapqueueName { get; set; }
        public string CapqueueTabname { get; set; }
        public string SourceEnabled { get; set; }
    }
}

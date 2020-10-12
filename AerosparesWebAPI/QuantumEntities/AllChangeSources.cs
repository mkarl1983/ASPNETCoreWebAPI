using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllChangeSources
    {
        public string SourceName { get; set; }
        public decimal? Dbid { get; set; }
        public string LogDirectory { get; set; }
        public string LogfilePattern { get; set; }
        public string SourceDescription { get; set; }
        public DateTime Created { get; set; }
        public string SourceType { get; set; }
        public string SourceDatabase { get; set; }
        public decimal? FirstScn { get; set; }
        public string Publisher { get; set; }
        public string CaptureName { get; set; }
        public string CaptureQueueName { get; set; }
        public string CaptureQueueTableName { get; set; }
        public string SourceEnabled { get; set; }
    }
}

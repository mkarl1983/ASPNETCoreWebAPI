using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroupExportInfo
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string VersionName { get; set; }
        public decimal Version { get; set; }
        public string ExportVersion { get; set; }
        public string PlatformName { get; set; }
        public DateTime ExportTime { get; set; }
        public decimal? ExportScn { get; set; }
        public string SourceGlobalName { get; set; }
    }
}

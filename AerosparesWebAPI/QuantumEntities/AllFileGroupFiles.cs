using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroupFiles
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string VersionName { get; set; }
        public decimal Version { get; set; }
        public string FileName { get; set; }
        public string FileDirectory { get; set; }
        public string FileType { get; set; }
        public decimal? FileSize { get; set; }
        public decimal? FileBlockSize { get; set; }
        public string Comments { get; set; }
    }
}

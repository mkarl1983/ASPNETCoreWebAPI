using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroupFiles1
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string VersionName { get; set; }
        public decimal VersionId { get; set; }
        public Guid VersionGuid { get; set; }
        public string FileName { get; set; }
        public string FileDirectory { get; set; }
        public string FileType { get; set; }
        public decimal? FileSize { get; set; }
        public decimal? FileBlocksize { get; set; }
        public string Comments { get; set; }
        public string Creator { get; set; }
        public DateTimeOffset Created { get; set; }
    }
}

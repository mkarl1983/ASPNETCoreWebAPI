using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroupVersions1
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string VersionName { get; set; }
        public decimal VersionId { get; set; }
        public Guid VersionGuid { get; set; }
        public string Creator { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Comments { get; set; }
        public string DefaultDirectory { get; set; }
    }
}

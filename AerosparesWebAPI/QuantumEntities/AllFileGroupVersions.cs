using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroupVersions
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string VersionName { get; set; }
        public decimal Version { get; set; }
        public string Creator { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Comments { get; set; }
        public string DefaultDirectory { get; set; }
    }
}

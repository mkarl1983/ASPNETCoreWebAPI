using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroupTablespaces1
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string VersionName { get; set; }
        public decimal VersionId { get; set; }
        public Guid VersionGuid { get; set; }
        public string TablespaceName { get; set; }
    }
}

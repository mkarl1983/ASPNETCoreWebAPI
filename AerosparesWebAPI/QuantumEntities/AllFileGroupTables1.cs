using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroupTables1
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string VersionName { get; set; }
        public decimal VersionId { get; set; }
        public Guid VersionGuid { get; set; }
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string TablespaceName { get; set; }
        public decimal? Scn { get; set; }
    }
}

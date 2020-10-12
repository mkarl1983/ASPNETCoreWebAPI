using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllFileGroups
    {
        public string FileGroupOwner { get; set; }
        public string FileGroupName { get; set; }
        public string KeepFiles { get; set; }
        public decimal MinVersions { get; set; }
        public decimal MaxVersions { get; set; }
        public decimal RetentionDays { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Comments { get; set; }
        public string DefaultDirectory { get; set; }
    }
}

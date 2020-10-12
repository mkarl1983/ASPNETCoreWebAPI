using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyInstantiatedObjects
    {
        public string SourceDatabase { get; set; }
        public string SourceObjectOwner { get; set; }
        public string SourceObjectName { get; set; }
        public string SourceObjectType { get; set; }
        public decimal? InstantiationScn { get; set; }
        public decimal? IgnoreScn { get; set; }
        public string ApplyDatabaseLink { get; set; }
    }
}

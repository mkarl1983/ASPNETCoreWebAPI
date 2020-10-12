using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyInstantiatedGlobal
    {
        public string SourceDatabase { get; set; }
        public decimal? InstantiationScn { get; set; }
        public string ApplyDatabaseLink { get; set; }
    }
}

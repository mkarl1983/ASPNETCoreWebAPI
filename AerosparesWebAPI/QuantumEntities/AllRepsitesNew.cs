using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepsitesNew
    {
        public Guid ExtensionId { get; set; }
        public string Gowner { get; set; }
        public string Gname { get; set; }
        public string Dblink { get; set; }
        public string FullInstantiation { get; set; }
        public string MasterStatus { get; set; }
    }
}

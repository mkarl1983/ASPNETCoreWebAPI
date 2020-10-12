using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllEditions
    {
        public string EditionName { get; set; }
        public string ParentEditionName { get; set; }
        public string Usable { get; set; }
    }
}

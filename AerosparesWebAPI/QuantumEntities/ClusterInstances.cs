using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ClusterInstances
    {
        public decimal? InstanceNumber { get; set; }
        public string DatabaseName { get; set; }
        public string InstName { get; set; }
        public string NodeName { get; set; }
        public decimal? Sparen1 { get; set; }
        public decimal? Sparen2 { get; set; }
        public string Sparevc1 { get; set; }
        public string Sparevc2 { get; set; }
    }
}

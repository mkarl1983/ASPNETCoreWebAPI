using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepobject
    {
        public string Sname { get; set; }
        public string Oname { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string GenerationStatus { get; set; }
        public decimal? Id { get; set; }
        public string ObjectComment { get; set; }
        public string Gname { get; set; }
        public string MinCommunication { get; set; }
        public string ReplicationTriggerExists { get; set; }
        public string InternalPackageExists { get; set; }
        public string GroupOwner { get; set; }
        public string NestedTable { get; set; }
    }
}

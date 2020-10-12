using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXscAggregatePrivilege
    {
        public string AggregatePrivilegeName { get; set; }
        public string AggregatePrivilegeTargetNs { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PrivilegeName { get; set; }
        public string PrivilegeTargetNamespace { get; set; }
    }
}

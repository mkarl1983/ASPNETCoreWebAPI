using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllGoldengatePrivileges
    {
        public string Username { get; set; }
        public string PrivilegeType { get; set; }
        public string GrantSelectPrivileges { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepgroupPrivileges
    {
        public string Username { get; set; }
        public string Gname { get; set; }
        public DateTime Created { get; set; }
        public string Receiver { get; set; }
        public string ProxySnapadmin { get; set; }
        public string Owner { get; set; }
    }
}

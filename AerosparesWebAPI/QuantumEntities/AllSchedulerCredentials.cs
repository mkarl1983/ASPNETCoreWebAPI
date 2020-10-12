using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerCredentials
    {
        public string Owner { get; set; }
        public string CredentialName { get; set; }
        public string Username { get; set; }
        public string DatabaseRole { get; set; }
        public string WindowsDomain { get; set; }
        public string Comments { get; set; }
    }
}

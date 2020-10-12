using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqInternetUsers
    {
        public string AgentName { get; set; }
        public string DbUsername { get; set; }
        public string HttpEnabled { get; set; }
        public string SmtpEnabled { get; set; }
        public string FtpEnabled { get; set; }
    }
}

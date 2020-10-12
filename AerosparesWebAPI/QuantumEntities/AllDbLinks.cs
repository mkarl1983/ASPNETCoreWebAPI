using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDbLinks
    {
        public string Owner { get; set; }
        public string DbLink { get; set; }
        public string Username { get; set; }
        public string Host { get; set; }
        public DateTime Created { get; set; }
    }
}

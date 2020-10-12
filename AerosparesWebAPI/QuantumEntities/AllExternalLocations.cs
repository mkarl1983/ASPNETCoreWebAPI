using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllExternalLocations
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string Location { get; set; }
        public string DirectoryOwner { get; set; }
        public string DirectoryName { get; set; }
    }
}

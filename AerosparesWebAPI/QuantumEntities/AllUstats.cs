using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllUstats
    {
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string PartitionName { get; set; }
        public string ObjectType { get; set; }
        public string Association { get; set; }
        public string ColumnName { get; set; }
        public string StatstypeSchema { get; set; }
        public string StatstypeName { get; set; }
        public byte[] Statistics { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqMessageTypes
    {
        public Guid QueueOid { get; set; }
        public string SchemaName { get; set; }
        public string QueueName { get; set; }
        public string TransName { get; set; }
        public string Destination { get; set; }
        public Guid? Toid { get; set; }
        public decimal? Version { get; set; }
        public string Verified { get; set; }
        public decimal? Properties { get; set; }
        public string NetworkName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllProbeObjects
    {
        public string Owner { get; set; }
        public string ObjectName { get; set; }
        public string SubobjectName { get; set; }
        public decimal ObjectId { get; set; }
        public decimal? DataObjectId { get; set; }
        public string ObjectType { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastDdlTime { get; set; }
        public string Timestamp { get; set; }
        public string Status { get; set; }
        public string Temporary { get; set; }
        public string Generated { get; set; }
        public string Secondary { get; set; }
        public decimal Namespace { get; set; }
        public string EditionName { get; set; }
        public string Debuginfo { get; set; }
    }
}

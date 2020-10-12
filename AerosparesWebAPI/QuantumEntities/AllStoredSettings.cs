using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStoredSettings
    {
        public string Owner { get; set; }
        public string ObjectName { get; set; }
        public decimal ObjectId { get; set; }
        public string ObjectType { get; set; }
        public string ParamName { get; set; }
        public string ParamValue { get; set; }
    }
}

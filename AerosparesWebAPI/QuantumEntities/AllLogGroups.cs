using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllLogGroups
    {
        public string Owner { get; set; }
        public string LogGroupName { get; set; }
        public string TableName { get; set; }
        public string LogGroupType { get; set; }
        public string Always { get; set; }
        public string Generated { get; set; }
    }
}

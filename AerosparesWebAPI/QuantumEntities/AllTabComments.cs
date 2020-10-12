using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabComments
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string TableType { get; set; }
        public string Comments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJoinIndColumns
    {
        public string IndexOwner { get; set; }
        public string IndexName { get; set; }
        public string InnerTableOwner { get; set; }
        public string InnerTableName { get; set; }
        public string InnerTableColumn { get; set; }
        public string OuterTableOwner { get; set; }
        public string OuterTableName { get; set; }
        public string OuterTableColumn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepresolutionStatistics
    {
        public string Sname { get; set; }
        public string Oname { get; set; }
        public string ConflictType { get; set; }
        public string ReferenceName { get; set; }
        public string MethodName { get; set; }
        public string FunctionName { get; set; }
        public string PriorityGroup { get; set; }
        public DateTime ResolvedDate { get; set; }
        public string PrimaryKeyValue { get; set; }
    }
}

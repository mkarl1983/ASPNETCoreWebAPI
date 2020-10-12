using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepresolution
    {
        public string Sname { get; set; }
        public string Oname { get; set; }
        public string ConflictType { get; set; }
        public string ReferenceName { get; set; }
        public decimal SequenceNo { get; set; }
        public string MethodName { get; set; }
        public string FunctionName { get; set; }
        public string PriorityGroup { get; set; }
        public string ResolutionComment { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMviewJoins
    {
        public string Owner { get; set; }
        public string MviewName { get; set; }
        public string Detailobj1Owner { get; set; }
        public string Detailobj1Relation { get; set; }
        public string Detailobj1Column { get; set; }
        public string Operator { get; set; }
        public string OperatorType { get; set; }
        public string Detailobj2Owner { get; set; }
        public string Detailobj2Relation { get; set; }
        public string Detailobj2Column { get; set; }
    }
}

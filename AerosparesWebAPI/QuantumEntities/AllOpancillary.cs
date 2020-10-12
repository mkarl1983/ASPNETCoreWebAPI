using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllOpancillary
    {
        public string Owner { get; set; }
        public string OperatorName { get; set; }
        public decimal Binding { get; set; }
        public string PrimopOwner { get; set; }
        public string PrimopName { get; set; }
        public decimal PrimopBind { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ApplyDestObjOps
    {
        public decimal ObjectNumber { get; set; }
        public string Sname { get; set; }
        public string Oname { get; set; }
        public string ApplyName { get; set; }
        public decimal ApplyOperation { get; set; }
        public string ErrorHandler { get; set; }
        public string UserApplyProcedure { get; set; }
        public string HandlerName { get; set; }
        public string AssembleLobs { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
    }
}

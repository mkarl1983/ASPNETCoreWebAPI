using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllProcedures
    {
        public string Owner { get; set; }
        public string ObjectName { get; set; }
        public string ProcedureName { get; set; }
        public decimal? ObjectId { get; set; }
        public decimal? SubprogramId { get; set; }
        public string Overload { get; set; }
        public string ObjectType { get; set; }
        public string Aggregate { get; set; }
        public string Pipelined { get; set; }
        public string Impltypeowner { get; set; }
        public string Impltypename { get; set; }
        public string Parallel { get; set; }
        public string Interface { get; set; }
        public string Deterministic { get; set; }
        public string Authid { get; set; }
    }
}

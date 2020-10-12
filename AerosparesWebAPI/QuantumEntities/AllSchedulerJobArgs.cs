using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerJobArgs
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string ArgumentName { get; set; }
        public decimal? ArgumentPosition { get; set; }
        public string ArgumentType { get; set; }
        public string Value { get; set; }
        public string OutArgument { get; set; }
    }
}

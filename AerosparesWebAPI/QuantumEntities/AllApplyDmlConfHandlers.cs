using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyDmlConfHandlers
    {
        public string ApplyName { get; set; }
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string SourceObjectOwner { get; set; }
        public string SourceObjectName { get; set; }
        public string CommandType { get; set; }
        public string ConflictType { get; set; }
        public string MethodName { get; set; }
        public string ConflictHandlerName { get; set; }
        public string ResolutionColumn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyChangeHandlers
    {
        public string ChangeTableOwner { get; set; }
        public string ChangeTableName { get; set; }
        public string SourceTableOwner { get; set; }
        public string SourceTableName { get; set; }
        public string HandlerName { get; set; }
        public string CaptureValues { get; set; }
        public string ApplyName { get; set; }
        public string OperationName { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? ModificationTime { get; set; }
    }
}

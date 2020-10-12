using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ApplyChangeHandlers
    {
        public string ChangeTableOwner { get; set; }
        public string ChangeTableName { get; set; }
        public string SourceTableOwner { get; set; }
        public string SourceTableName { get; set; }
        public string HandlerName { get; set; }
        public decimal? CaptureValues { get; set; }
        public string ApplyName { get; set; }
        public decimal? Operation { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? ModificationTime { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
        public string Spare4 { get; set; }
        public DateTime? Spare5 { get; set; }
        public DateTime? Spare6 { get; set; }
        public byte[] Spare7 { get; set; }
    }
}

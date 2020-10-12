using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApplyErrorMessages
    {
        public Guid? MessageId { get; set; }
        public string LocalTransactionId { get; set; }
        public decimal? TransactionMessageNumber { get; set; }
        public decimal? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string SourceObjectOwner { get; set; }
        public string SourceObjectName { get; set; }
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string PrimaryKey { get; set; }
        public byte[] Position { get; set; }
        public string Operation { get; set; }
        public string Message { get; set; }
    }
}

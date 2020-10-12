using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ApplyErrorTxn
    {
        public Guid? MsgId { get; set; }
        public string LocalTransactionId { get; set; }
        public decimal? TxnMessageNumber { get; set; }
        public decimal? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public decimal? Flags { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public string Spare3 { get; set; }
        public string Spare4 { get; set; }
        public byte[] Spare5 { get; set; }
        public DateTime? Spare6 { get; set; }
        public string SourceObjectOwner { get; set; }
        public string SourceObjectName { get; set; }
        public string DestObjectOwner { get; set; }
        public string DestObjectName { get; set; }
        public string PrimaryKey { get; set; }
        public byte[] Position { get; set; }
        public decimal? MessageFlags { get; set; }
        public string Operation { get; set; }
    }
}

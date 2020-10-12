﻿using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqAqEventTableF
    {
        public string QName { get; set; }
        public string RowId { get; set; }
        public Guid Msgid { get; set; }
        public string Corrid { get; set; }
        public decimal? Priority { get; set; }
        public decimal? State { get; set; }
        public DateTime? Delay { get; set; }
        public decimal? Expiration { get; set; }
        public DateTime? EnqTime { get; set; }
        public decimal? EnqUid { get; set; }
        public string EnqTid { get; set; }
        public DateTime? DeqTime { get; set; }
        public decimal? DeqUid { get; set; }
        public string DeqTid { get; set; }
        public decimal? RetryCount { get; set; }
        public string ExceptionQschema { get; set; }
        public string ExceptionQueue { get; set; }
        public decimal? Cscn { get; set; }
        public decimal? Dscn { get; set; }
        public decimal? ChainNo { get; set; }
        public decimal? LocalOrderNo { get; set; }
        public DateTime? TimeManagerInfo { get; set; }
        public decimal? StepNo { get; set; }
        public decimal QueueId { get; set; }
    }
}

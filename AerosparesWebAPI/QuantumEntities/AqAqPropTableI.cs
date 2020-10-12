using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AqAqPropTableI
    {
        public decimal Subscriber { get; set; }
        public string Name { get; set; }
        public decimal Queue { get; set; }
        public DateTime MsgEnqTime { get; set; }
        public decimal MsgStepNo { get; set; }
        public decimal MsgChainNo { get; set; }
        public decimal MsgLocalOrderNo { get; set; }
        public Guid Msgid { get; set; }
        public string Hint { get; set; }
        public Guid? Spare { get; set; }
    }
}

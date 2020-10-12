using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ApplyDestObj
    {
        public decimal Id { get; set; }
        public string SourceOwner { get; set; }
        public string SourceName { get; set; }
        public decimal Type { get; set; }
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? Apply { get; set; }
        public decimal? Status { get; set; }
        public string ErrorNotifier { get; set; }
        public decimal? Spare1 { get; set; }
    }
}

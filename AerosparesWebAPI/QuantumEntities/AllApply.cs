using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllApply
    {
        public string ApplyName { get; set; }
        public string QueueName { get; set; }
        public string QueueOwner { get; set; }
        public string ApplyCaptured { get; set; }
        public string RuleSetName { get; set; }
        public string RuleSetOwner { get; set; }
        public string ApplyUser { get; set; }
        public string ApplyDatabaseLink { get; set; }
        public byte[] ApplyTag { get; set; }
        public string DdlHandler { get; set; }
        public string PrecommitHandler { get; set; }
        public string MessageHandler { get; set; }
        public string Status { get; set; }
        public decimal? MaxAppliedMessageNumber { get; set; }
        public string NegativeRuleSetName { get; set; }
        public string NegativeRuleSetOwner { get; set; }
        public DateTime? StatusChangeTime { get; set; }
        public decimal? ErrorNumber { get; set; }
        public string ErrorMessage { get; set; }
        public string MessageDeliveryMode { get; set; }
        public string Purpose { get; set; }
    }
}

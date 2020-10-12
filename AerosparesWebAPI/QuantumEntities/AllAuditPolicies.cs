using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllAuditPolicies
    {
        public string ObjectSchema { get; set; }
        public string ObjectName { get; set; }
        public string PolicyOwner { get; set; }
        public string PolicyName { get; set; }
        public string PolicyText { get; set; }
        public string PolicyColumn { get; set; }
        public string PfSchema { get; set; }
        public string PfPackage { get; set; }
        public string PfFunction { get; set; }
        public string Enabled { get; set; }
        public string Sel { get; set; }
        public string Ins { get; set; }
        public string Upd { get; set; }
        public string Del { get; set; }
        public string AuditTrail { get; set; }
        public string PolicyColumnOptions { get; set; }
    }
}

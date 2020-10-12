using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerChainSteps
    {
        public string Owner { get; set; }
        public string ChainName { get; set; }
        public string StepName { get; set; }
        public string ProgramOwner { get; set; }
        public string ProgramName { get; set; }
        public string EventScheduleOwner { get; set; }
        public string EventScheduleName { get; set; }
        public string EventQueueOwner { get; set; }
        public string EventQueueName { get; set; }
        public string EventQueueAgent { get; set; }
        public string EventCondition { get; set; }
        public string CredentialOwner { get; set; }
        public string CredentialName { get; set; }
        public string Destination { get; set; }
        public string Skip { get; set; }
        public string Pause { get; set; }
        public string PauseBefore { get; set; }
        public string RestartOnRecovery { get; set; }
        public string RestartOnFailure { get; set; }
        public string StepType { get; set; }
        public TimeSpan? Timeout { get; set; }
    }
}

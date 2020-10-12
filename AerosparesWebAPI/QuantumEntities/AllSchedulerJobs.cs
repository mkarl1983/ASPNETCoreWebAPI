using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerJobs
    {
        public string Owner { get; set; }
        public string JobName { get; set; }
        public string JobSubname { get; set; }
        public string JobStyle { get; set; }
        public string JobCreator { get; set; }
        public string ClientId { get; set; }
        public string GlobalUid { get; set; }
        public string ProgramOwner { get; set; }
        public string ProgramName { get; set; }
        public string JobType { get; set; }
        public string JobAction { get; set; }
        public decimal? NumberOfArguments { get; set; }
        public string ScheduleOwner { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleType { get; set; }
        public DateTimeOffset? StartDate { get; set; }
        public string RepeatInterval { get; set; }
        public string EventQueueOwner { get; set; }
        public string EventQueueName { get; set; }
        public string EventQueueAgent { get; set; }
        public string EventCondition { get; set; }
        public string EventRule { get; set; }
        public string FileWatcherOwner { get; set; }
        public string FileWatcherName { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public string JobClass { get; set; }
        public string Enabled { get; set; }
        public string AutoDrop { get; set; }
        public string Restartable { get; set; }
        public string State { get; set; }
        public decimal? JobPriority { get; set; }
        public decimal? RunCount { get; set; }
        public decimal? MaxRuns { get; set; }
        public decimal? FailureCount { get; set; }
        public decimal? MaxFailures { get; set; }
        public decimal? RetryCount { get; set; }
        public DateTimeOffset? LastStartDate { get; set; }
        public TimeSpan? LastRunDuration { get; set; }
        public DateTimeOffset? NextRunDate { get; set; }
        public TimeSpan? ScheduleLimit { get; set; }
        public TimeSpan? MaxRunDuration { get; set; }
        public string LoggingLevel { get; set; }
        public string StopOnWindowClose { get; set; }
        public string InstanceStickiness { get; set; }
        public string RaiseEvents { get; set; }
        public string System { get; set; }
        public decimal? JobWeight { get; set; }
        public string NlsEnv { get; set; }
        public string Source { get; set; }
        public decimal? NumberOfDestinations { get; set; }
        public string DestinationOwner { get; set; }
        public string Destination { get; set; }
        public string CredentialOwner { get; set; }
        public string CredentialName { get; set; }
        public decimal? InstanceId { get; set; }
        public string DeferredDrop { get; set; }
        public string AllowRunsInRestrictedMode { get; set; }
        public string Comments { get; set; }
        public decimal? Flags { get; set; }
    }
}

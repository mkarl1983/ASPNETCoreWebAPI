using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSchedulerFileWatchers
    {
        public string Owner { get; set; }
        public string FileWatcherName { get; set; }
        public string Enabled { get; set; }
        public string DestinationOwner { get; set; }
        public string Destination { get; set; }
        public string DirectoryPath { get; set; }
        public string FileName { get; set; }
        public string CredentialOwner { get; set; }
        public string CredentialName { get; set; }
        public decimal MinFileSize { get; set; }
        public TimeSpan? SteadyStateDuration { get; set; }
        public DateTimeOffset? LastModifiedTime { get; set; }
        public string Comments { get; set; }
    }
}

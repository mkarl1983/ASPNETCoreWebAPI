using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllIndextypes
    {
        public string Owner { get; set; }
        public string IndextypeName { get; set; }
        public string ImplementationSchema { get; set; }
        public string ImplementationName { get; set; }
        public decimal? InterfaceVersion { get; set; }
        public decimal ImplementationVersion { get; set; }
        public decimal? NumberOfOperators { get; set; }
        public string Partitioning { get; set; }
        public string ArrayDml { get; set; }
        public string MaintenanceType { get; set; }
    }
}

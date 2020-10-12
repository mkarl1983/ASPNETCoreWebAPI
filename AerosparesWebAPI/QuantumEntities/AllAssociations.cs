using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllAssociations
    {
        public string ObjectOwner { get; set; }
        public string ObjectName { get; set; }
        public string ColumnName { get; set; }
        public string ObjectType { get; set; }
        public string StatstypeSchema { get; set; }
        public string StatstypeName { get; set; }
        public decimal? DefSelectivity { get; set; }
        public decimal? DefCpuCost { get; set; }
        public decimal? DefIoCost { get; set; }
        public decimal? DefNetCost { get; set; }
        public decimal? InterfaceVersion { get; set; }
        public string MaintenanceType { get; set; }
    }
}

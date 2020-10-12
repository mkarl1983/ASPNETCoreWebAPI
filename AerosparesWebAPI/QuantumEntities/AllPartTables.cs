using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllPartTables
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string PartitioningType { get; set; }
        public string SubpartitioningType { get; set; }
        public decimal? PartitionCount { get; set; }
        public decimal? DefSubpartitionCount { get; set; }
        public decimal? PartitioningKeyCount { get; set; }
        public decimal? SubpartitioningKeyCount { get; set; }
        public string Status { get; set; }
        public string DefTablespaceName { get; set; }
        public decimal? DefPctFree { get; set; }
        public decimal? DefPctUsed { get; set; }
        public decimal? DefIniTrans { get; set; }
        public decimal? DefMaxTrans { get; set; }
        public string DefInitialExtent { get; set; }
        public string DefNextExtent { get; set; }
        public string DefMinExtents { get; set; }
        public string DefMaxExtents { get; set; }
        public string DefMaxSize { get; set; }
        public string DefPctIncrease { get; set; }
        public decimal? DefFreelists { get; set; }
        public decimal? DefFreelistGroups { get; set; }
        public string DefLogging { get; set; }
        public string DefCompression { get; set; }
        public string DefCompressFor { get; set; }
        public string DefBufferPool { get; set; }
        public string DefFlashCache { get; set; }
        public string DefCellFlashCache { get; set; }
        public string RefPtnConstraintName { get; set; }
        public string Interval { get; set; }
        public string IsNested { get; set; }
        public string DefSegmentCreation { get; set; }
    }
}

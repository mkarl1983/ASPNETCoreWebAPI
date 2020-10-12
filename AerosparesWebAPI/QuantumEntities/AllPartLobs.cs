using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllPartLobs
    {
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string LobName { get; set; }
        public string LobIndexName { get; set; }
        public decimal DefChunk { get; set; }
        public decimal DefPctversion { get; set; }
        public string DefCache { get; set; }
        public string DefInRow { get; set; }
        public string DefTablespaceName { get; set; }
        public string DefInitialExtent { get; set; }
        public string DefNextExtent { get; set; }
        public string DefMinExtents { get; set; }
        public string DefMaxExtents { get; set; }
        public string DefMaxSize { get; set; }
        public string DefRetention { get; set; }
        public string DefMinret { get; set; }
        public string DefPctIncrease { get; set; }
        public string DefFreelists { get; set; }
        public string DefFreelistGroups { get; set; }
        public string DefLogging { get; set; }
        public string DefBufferPool { get; set; }
        public string DefFlashCache { get; set; }
        public string DefCellFlashCache { get; set; }
        public string DefEncrypt { get; set; }
        public string DefCompress { get; set; }
        public string DefDeduplicate { get; set; }
        public string DefSecurefile { get; set; }
    }
}

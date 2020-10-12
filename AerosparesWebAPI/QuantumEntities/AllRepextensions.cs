using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepextensions
    {
        public Guid ExtensionId { get; set; }
        public string Request { get; set; }
        public string Masterdef { get; set; }
        public string ExportRequired { get; set; }
        public decimal? RepcatlogId { get; set; }
        public string ExtensionStatus { get; set; }
        public decimal? FlashbackScn { get; set; }
        public string BreakTransToMasterdef { get; set; }
        public string BreakTransToNewMasters { get; set; }
        public decimal? PercentageForCatchupMdef { get; set; }
        public decimal? CycleSecondsMdef { get; set; }
        public decimal? PercentageForCatchupNew { get; set; }
        public decimal? CycleSecondsNew { get; set; }
    }
}

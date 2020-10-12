using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class CdcChangeTables
    {
        public decimal Obj { get; set; }
        public string ChangeSetName { get; set; }
        public string SourceSchemaName { get; set; }
        public string SourceTableName { get; set; }
        public string ChangeTableSchema { get; set; }
        public string ChangeTableName { get; set; }
        public DateTime Created { get; set; }
        public decimal? CreatedScn { get; set; }
        public decimal? MvlFlag { get; set; }
        public string CapturedValues { get; set; }
        public string MvlTempLog { get; set; }
        public string MvlV7trigger { get; set; }
        public DateTime? LastAltered { get; set; }
        public decimal LowestScn { get; set; }
        public decimal? MvlOldestRid { get; set; }
        public decimal? MvlOldestPk { get; set; }
        public decimal? MvlOldestSeq { get; set; }
        public decimal? MvlOldestOid { get; set; }
        public decimal? MvlOldestNew { get; set; }
        public DateTime? MvlOldestRidTime { get; set; }
        public DateTime? MvlOldestPkTime { get; set; }
        public DateTime? MvlOldestSeqTime { get; set; }
        public DateTime? MvlOldestOidTime { get; set; }
        public DateTime? MvlOldestNewTime { get; set; }
        public string MvlBackcompatView { get; set; }
        public string MvlPhysmvl { get; set; }
        public decimal? HighestScn { get; set; }
        public DateTime? HighestTimestamp { get; set; }
        public decimal ChangeTableType { get; set; }
        public decimal MajorVersion { get; set; }
        public decimal MinorVersion { get; set; }
        public decimal? SourceTableObj { get; set; }
        public decimal? SourceTableVer { get; set; }
    }
}

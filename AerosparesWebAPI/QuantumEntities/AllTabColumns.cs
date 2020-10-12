using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabColumns
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string DataTypeMod { get; set; }
        public string DataTypeOwner { get; set; }
        public decimal DataLength { get; set; }
        public decimal? DataPrecision { get; set; }
        public decimal? DataScale { get; set; }
        public string Nullable { get; set; }
        public decimal? ColumnId { get; set; }
        public decimal? DefaultLength { get; set; }
        public string DataDefault { get; set; }
        public decimal? NumDistinct { get; set; }
        public byte[] LowValue { get; set; }
        public byte[] HighValue { get; set; }
        public decimal? Density { get; set; }
        public decimal? NumNulls { get; set; }
        public decimal? NumBuckets { get; set; }
        public DateTime? LastAnalyzed { get; set; }
        public decimal? SampleSize { get; set; }
        public string CharacterSetName { get; set; }
        public decimal? CharColDeclLength { get; set; }
        public string GlobalStats { get; set; }
        public string UserStats { get; set; }
        public decimal? AvgColLen { get; set; }
        public decimal? CharLength { get; set; }
        public string CharUsed { get; set; }
        public string V80FmtImage { get; set; }
        public string DataUpgraded { get; set; }
        public string Histogram { get; set; }
    }
}

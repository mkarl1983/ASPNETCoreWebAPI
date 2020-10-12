using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsKeepColumns
    {
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ValueType { get; set; }
        public decimal? Precedence { get; set; }
        public decimal? StepNumber { get; set; }
    }
}

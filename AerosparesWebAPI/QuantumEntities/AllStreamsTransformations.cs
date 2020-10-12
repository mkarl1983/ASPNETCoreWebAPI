using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsTransformations
    {
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string TransformType { get; set; }
        public string FromSchemaName { get; set; }
        public string ToSchemaName { get; set; }
        public string FromTableName { get; set; }
        public string ToTableName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string FromColumnName { get; set; }
        public string ToColumnName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public string ColumnFunction { get; set; }
        public string ValueType { get; set; }
        public string UserFunctionName { get; set; }
        public string SubsettingOperation { get; set; }
        public string DmlCondition { get; set; }
        public string DeclarativeType { get; set; }
        public decimal? Precedence { get; set; }
        public decimal? StepNumber { get; set; }
    }
}

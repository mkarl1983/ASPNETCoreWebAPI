using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTriggers
    {
        public string Owner { get; set; }
        public string TriggerName { get; set; }
        public string TriggerType { get; set; }
        public string TriggeringEvent { get; set; }
        public string TableOwner { get; set; }
        public string BaseObjectType { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string ReferencingNames { get; set; }
        public string WhenClause { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string ActionType { get; set; }
        public string TriggerBody { get; set; }
        public string Crossedition { get; set; }
        public string BeforeStatement { get; set; }
        public string BeforeRow { get; set; }
        public string AfterRow { get; set; }
        public string AfterStatement { get; set; }
        public string InsteadOfRow { get; set; }
        public string FireOnce { get; set; }
        public string ApplyServerOnly { get; set; }
    }
}

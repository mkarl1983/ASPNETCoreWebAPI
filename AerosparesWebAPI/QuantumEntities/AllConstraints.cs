using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllConstraints
    {
        public string Owner { get; set; }
        public string ConstraintName { get; set; }
        public string ConstraintType { get; set; }
        public string TableName { get; set; }
        public string SearchCondition { get; set; }
        public string ROwner { get; set; }
        public string RConstraintName { get; set; }
        public string DeleteRule { get; set; }
        public string Status { get; set; }
        public string Deferrable { get; set; }
        public string Deferred { get; set; }
        public string Validated { get; set; }
        public string Generated { get; set; }
        public string Bad { get; set; }
        public string Rely { get; set; }
        public DateTime? LastChange { get; set; }
        public string IndexOwner { get; set; }
        public string IndexName { get; set; }
        public string Invalid { get; set; }
        public string ViewRelated { get; set; }
    }
}

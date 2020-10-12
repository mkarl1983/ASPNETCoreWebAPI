using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepauditColumn
    {
        public string Sname { get; set; }
        public string Oname { get; set; }
        public string ColumnName { get; set; }
        public string BaseSname { get; set; }
        public string BaseOname { get; set; }
        public string BaseConflictType { get; set; }
        public string BaseReferenceName { get; set; }
        public string Attribute { get; set; }
    }
}

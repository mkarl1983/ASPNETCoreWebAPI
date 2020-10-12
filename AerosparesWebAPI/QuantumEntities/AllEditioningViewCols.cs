using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllEditioningViewCols
    {
        public string Owner { get; set; }
        public string ViewName { get; set; }
        public decimal ViewColumnId { get; set; }
        public string ViewColumnName { get; set; }
        public decimal TableColumnId { get; set; }
        public string TableColumnName { get; set; }
    }
}

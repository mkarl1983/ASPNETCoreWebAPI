using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class CdcChangeColumns
    {
        public decimal ChangeTableObj { get; set; }
        public string ColumnName { get; set; }
        public DateTime Created { get; set; }
        public decimal CreatedScn { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSubpartitionTemplates
    {
        public string UserName { get; set; }
        public string TableName { get; set; }
        public string SubpartitionName { get; set; }
        public decimal? SubpartitionPosition { get; set; }
        public string TablespaceName { get; set; }
        public string HighBound { get; set; }
    }
}

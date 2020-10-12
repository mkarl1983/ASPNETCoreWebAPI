using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class CdcSubscribedTables
    {
        public decimal Handle { get; set; }
        public decimal ChangeTableObj { get; set; }
        public string ViewName { get; set; }
        public string ViewStatus { get; set; }
        public decimal? MvFlag { get; set; }
        public byte[] MvColvec { get; set; }
    }
}

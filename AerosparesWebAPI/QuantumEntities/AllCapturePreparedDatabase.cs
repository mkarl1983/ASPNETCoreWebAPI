using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCapturePreparedDatabase
    {
        public DateTime? Timestamp { get; set; }
        public string SupplementalLogDataPk { get; set; }
        public string SupplementalLogDataUi { get; set; }
        public string SupplementalLogDataFk { get; set; }
        public string SupplementalLogDataAll { get; set; }
    }
}

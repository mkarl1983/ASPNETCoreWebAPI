﻿using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCapturePreparedTables
    {
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public decimal Scn { get; set; }
        public DateTime? Timestamp { get; set; }
        public string SupplementalLogDataPk { get; set; }
        public string SupplementalLogDataUi { get; set; }
        public string SupplementalLogDataFk { get; set; }
        public string SupplementalLogDataAll { get; set; }
    }
}

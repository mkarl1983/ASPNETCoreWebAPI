using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllLobTemplates
    {
        public string UserName { get; set; }
        public string TableName { get; set; }
        public string LobColName { get; set; }
        public string SubpartitionName { get; set; }
        public string LobSegmentName { get; set; }
        public string TablespaceName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllVarrays
    {
        public string Owner { get; set; }
        public string ParentTableName { get; set; }
        public string ParentTableColumn { get; set; }
        public string TypeOwner { get; set; }
        public string TypeName { get; set; }
        public string LobName { get; set; }
        public string StorageSpec { get; set; }
        public string ReturnType { get; set; }
        public string ElementSubstitutable { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllChangeTables
    {
        public string ChangeTableSchema { get; set; }
        public string ChangeTableName { get; set; }
        public string ChangeSetName { get; set; }
        public string SourceSchemaName { get; set; }
        public string SourceTableName { get; set; }
        public DateTime Created { get; set; }
        public decimal? CreatedScn { get; set; }
        public string CapturedValues { get; set; }
        public decimal PubId { get; set; }
    }
}

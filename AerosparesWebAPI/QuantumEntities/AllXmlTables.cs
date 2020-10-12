using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXmlTables
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string Xmlschema { get; set; }
        public string SchemaOwner { get; set; }
        public string ElementName { get; set; }
        public string StorageType { get; set; }
        public string Anyschema { get; set; }
        public string Nonschema { get; set; }
    }
}

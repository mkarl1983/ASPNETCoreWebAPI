using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllXmlSchemas
    {
        public string Owner { get; set; }
        public string SchemaUrl { get; set; }
        public string Local { get; set; }
        public string Schema { get; set; }
        public string IntObjname { get; set; }
        public string QualSchemaUrl { get; set; }
        public string HierType { get; set; }
        public string Binary { get; set; }
        public Guid? SchemaId { get; set; }
        public string Hidden { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMethodResults
    {
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public string MethodName { get; set; }
        public decimal MethodNo { get; set; }
        public string ResultTypeMod { get; set; }
        public string ResultTypeOwner { get; set; }
        public string ResultTypeName { get; set; }
        public string CharacterSetName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqljTypeMethods
    {
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public string MethodName { get; set; }
        public string ExternalVarName { get; set; }
        public decimal MethodNo { get; set; }
        public string MethodType { get; set; }
        public decimal Parameters { get; set; }
        public decimal Results { get; set; }
        public string Final { get; set; }
        public string Instantiable { get; set; }
        public string Overriding { get; set; }
        public string Inherited { get; set; }
    }
}

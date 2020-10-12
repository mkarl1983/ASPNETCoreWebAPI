using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMethodParams
    {
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public string MethodName { get; set; }
        public decimal MethodNo { get; set; }
        public string ParamName { get; set; }
        public decimal ParamNo { get; set; }
        public string ParamMode { get; set; }
        public string ParamTypeMod { get; set; }
        public string ParamTypeOwner { get; set; }
        public string ParamTypeName { get; set; }
        public string CharacterSetName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTypes
    {
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public Guid? TypeOid { get; set; }
        public string Typecode { get; set; }
        public decimal? Attributes { get; set; }
        public decimal? Methods { get; set; }
        public string Predefined { get; set; }
        public string Incomplete { get; set; }
        public string Final { get; set; }
        public string Instantiable { get; set; }
        public string SupertypeOwner { get; set; }
        public string SupertypeName { get; set; }
        public decimal? LocalAttributes { get; set; }
        public decimal? LocalMethods { get; set; }
        public Guid? Typeid { get; set; }
    }
}

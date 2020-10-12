using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTypeVersions
    {
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public decimal Version { get; set; }
        public string Typecode { get; set; }
        public string Status { get; set; }
        public decimal Line { get; set; }
        public string Text { get; set; }
        public byte[] Hashcode { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Access
    {
        public decimal DObj { get; set; }
        public decimal Order { get; set; }
        public byte[] Columns { get; set; }
        public decimal Types { get; set; }
    }
}

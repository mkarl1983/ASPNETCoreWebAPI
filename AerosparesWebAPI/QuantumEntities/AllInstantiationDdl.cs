using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllInstantiationDdl
    {
        public decimal RefreshTemplateId { get; set; }
        public string DdlText { get; set; }
        public decimal DdlNum { get; set; }
        public decimal Phase { get; set; }
    }
}

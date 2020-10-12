using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSqljTypeAttrs
    {
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public string AttrName { get; set; }
        public string ExternalAttrName { get; set; }
        public string AttrTypeMod { get; set; }
        public string AttrTypeOwner { get; set; }
        public string AttrTypeName { get; set; }
        public decimal? Length { get; set; }
        public decimal? Precision { get; set; }
        public decimal? Scale { get; set; }
        public string CharacterSetName { get; set; }
        public decimal AttrNo { get; set; }
        public string Inherited { get; set; }
    }
}

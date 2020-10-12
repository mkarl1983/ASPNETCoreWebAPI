using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllCollTypes
    {
        public string Owner { get; set; }
        public string TypeName { get; set; }
        public string CollType { get; set; }
        public decimal? UpperBound { get; set; }
        public string ElemTypeMod { get; set; }
        public string ElemTypeOwner { get; set; }
        public string ElemTypeName { get; set; }
        public decimal? Length { get; set; }
        public decimal? Precision { get; set; }
        public decimal? Scale { get; set; }
        public string CharacterSetName { get; set; }
        public string ElemStorage { get; set; }
        public string NullsStored { get; set; }
        public string CharUsed { get; set; }
    }
}

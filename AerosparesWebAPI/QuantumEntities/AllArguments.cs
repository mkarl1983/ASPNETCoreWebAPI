using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllArguments
    {
        public string Owner { get; set; }
        public string ObjectName { get; set; }
        public string PackageName { get; set; }
        public decimal ObjectId { get; set; }
        public string Overload { get; set; }
        public decimal? SubprogramId { get; set; }
        public string ArgumentName { get; set; }
        public decimal Position { get; set; }
        public decimal Sequence { get; set; }
        public decimal DataLevel { get; set; }
        public string DataType { get; set; }
        public string Defaulted { get; set; }
        public string DefaultValue { get; set; }
        public decimal? DefaultLength { get; set; }
        public string InOut { get; set; }
        public decimal? DataLength { get; set; }
        public decimal? DataPrecision { get; set; }
        public decimal? DataScale { get; set; }
        public decimal? Radix { get; set; }
        public string CharacterSetName { get; set; }
        public string TypeOwner { get; set; }
        public string TypeName { get; set; }
        public string TypeSubname { get; set; }
        public string TypeLink { get; set; }
        public string PlsType { get; set; }
        public decimal? CharLength { get; set; }
        public string CharUsed { get; set; }
    }
}

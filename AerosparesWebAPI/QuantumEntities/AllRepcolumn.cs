using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepcolumn
    {
        public string Sname { get; set; }
        public string Oname { get; set; }
        public string Type { get; set; }
        public string Cname { get; set; }
        public decimal? Id { get; set; }
        public decimal? Pos { get; set; }
        public string CompareOldOnDelete { get; set; }
        public string CompareOldOnUpdate { get; set; }
        public string SendOldOnDelete { get; set; }
        public string SendOldOnUpdate { get; set; }
        public string Ctype { get; set; }
        public Guid? CtypeToid { get; set; }
        public string CtypeOwner { get; set; }
        public string CtypeHashcode { get; set; }
        public string CtypeMod { get; set; }
        public string DataLength { get; set; }
        public string DataPrecision { get; set; }
        public string DataScale { get; set; }
        public string Nullable { get; set; }
        public string CharacterSetName { get; set; }
        public string Top { get; set; }
        public decimal? CharLength { get; set; }
        public string CharUsed { get; set; }
    }
}

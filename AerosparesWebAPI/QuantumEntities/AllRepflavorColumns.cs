using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepflavorColumns
    {
        public string Fname { get; set; }
        public string Gname { get; set; }
        public string Sname { get; set; }
        public string Oname { get; set; }
        public string Cname { get; set; }
        public string Type { get; set; }
        public decimal? Pos { get; set; }
        public string GroupOwner { get; set; }
        public Guid? TypeToid { get; set; }
        public string TypeOwner { get; set; }
        public string TypeHashcode { get; set; }
        public string TypeMod { get; set; }
        public string Top { get; set; }
    }
}

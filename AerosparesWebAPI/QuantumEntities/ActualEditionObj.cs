using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ActualEditionObj
    {
        public decimal Obj { get; set; }
        public decimal? Dataobj { get; set; }
        public decimal DefiningOwner { get; set; }
        public string Name { get; set; }
        public decimal Namespace { get; set; }
        public string Subname { get; set; }
        public decimal Type { get; set; }
        public DateTime Ctime { get; set; }
        public DateTime Mtime { get; set; }
        public DateTime Stime { get; set; }
        public decimal Status { get; set; }
        public string Remoteowner { get; set; }
        public string Linkname { get; set; }
        public decimal? Flags { get; set; }
        public Guid? Oid { get; set; }
        public decimal? Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public decimal? Spare3 { get; set; }
        public string Spare4 { get; set; }
        public string Spare5 { get; set; }
        public DateTime? Spare6 { get; set; }
        public decimal? Owner { get; set; }
        public string DefiningEdition { get; set; }
    }
}

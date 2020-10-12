using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class Aud
    {
        public decimal Sessionid { get; set; }
        public decimal Entryid { get; set; }
        public decimal Statement { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Userid { get; set; }
        public string Userhost { get; set; }
        public string Terminal { get; set; }
        public decimal Action { get; set; }
        public decimal Returncode { get; set; }
        public string ObjCreator { get; set; }
        public string ObjName { get; set; }
        public string AuthPrivileges { get; set; }
        public string AuthGrantee { get; set; }
        public string NewOwner { get; set; }
        public string NewName { get; set; }
        public string SesActions { get; set; }
        public decimal? SesTid { get; set; }
        public decimal? LogoffLread { get; set; }
        public decimal? LogoffPread { get; set; }
        public decimal? LogoffLwrite { get; set; }
        public decimal? LogoffDead { get; set; }
        public DateTime? LogoffTime { get; set; }
        public string CommentText { get; set; }
        public string Clientid { get; set; }
        public string Spare1 { get; set; }
        public decimal? Spare2 { get; set; }
        public byte[] ObjLabel { get; set; }
        public byte[] SesLabel { get; set; }
        public decimal? PrivUsed { get; set; }
        public decimal? Sessioncpu { get; set; }
        public DateTime? Ntimestamp { get; set; }
        public decimal? ProxySid { get; set; }
        public string UserGuid { get; set; }
        public decimal? Instance { get; set; }
        public string Process { get; set; }
        public byte[] Xid { get; set; }
        public string Auditid { get; set; }
        public decimal? Scn { get; set; }
        public decimal? Dbid { get; set; }
        public string Sqlbind { get; set; }
        public string Sqltext { get; set; }
        public string ObjEdition { get; set; }
    }
}

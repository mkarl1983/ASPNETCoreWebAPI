using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepcatlog
    {
        public decimal? Id { get; set; }
        public string Source { get; set; }
        public string Userid { get; set; }
        public DateTime? Timestamp { get; set; }
        public string Role { get; set; }
        public string Master { get; set; }
        public string Sname { get; set; }
        public string Request { get; set; }
        public string Oname { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public decimal? Errnum { get; set; }
        public string Gname { get; set; }
    }
}

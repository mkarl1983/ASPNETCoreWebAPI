using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepflavors
    {
        public decimal FlavorId { get; set; }
        public string Gname { get; set; }
        public string Fname { get; set; }
        public DateTime? CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public string Published { get; set; }
        public string GroupOwner { get; set; }
    }
}

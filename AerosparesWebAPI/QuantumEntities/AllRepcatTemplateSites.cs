using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepcatTemplateSites
    {
        public string RefreshTemplateName { get; set; }
        public string RefreshGroupName { get; set; }
        public string TemplateOwner { get; set; }
        public string UserName { get; set; }
        public string SiteName { get; set; }
        public string RepapiSiteName { get; set; }
        public string Status { get; set; }
        public DateTime? InstantiationDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepcatRefreshTemplates
    {
        public string RefreshTemplateName { get; set; }
        public string Owner { get; set; }
        public string RefreshGroupName { get; set; }
        public string TemplateComment { get; set; }
        public string PublicTemplate { get; set; }
    }
}

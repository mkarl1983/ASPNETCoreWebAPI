using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepcatTemplateParms
    {
        public string RefreshTemplateName { get; set; }
        public string Owner { get; set; }
        public string RefreshGroupName { get; set; }
        public string TemplateComment { get; set; }
        public string PublicTemplate { get; set; }
        public string ParameterName { get; set; }
        public string DefaultParmValue { get; set; }
        public string PromptString { get; set; }
        public string UserOverride { get; set; }
    }
}

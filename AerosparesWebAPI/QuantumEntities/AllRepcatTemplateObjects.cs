using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllRepcatTemplateObjects
    {
        public string RefreshTemplateName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public decimal DdlNum { get; set; }
        public string DdlText { get; set; }
        public string MasterRollbackSegment { get; set; }
        public string DerivedFromSname { get; set; }
        public string DerivedFromOname { get; set; }
        public decimal? FlavorId { get; set; }
    }
}

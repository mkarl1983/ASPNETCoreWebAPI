using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllPlsqlObjectSettings
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal? PlsqlOptimizeLevel { get; set; }
        public string PlsqlCodeType { get; set; }
        public string PlsqlDebug { get; set; }
        public string PlsqlWarnings { get; set; }
        public string NlsLengthSemantics { get; set; }
        public string PlsqlCcflags { get; set; }
        public string PlscopeSettings { get; set; }
    }
}

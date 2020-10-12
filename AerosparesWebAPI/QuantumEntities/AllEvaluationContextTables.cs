using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllEvaluationContextTables
    {
        public string EvaluationContextOwner { get; set; }
        public string EvaluationContextName { get; set; }
        public string TableAlias { get; set; }
        public string TableName { get; set; }
    }
}

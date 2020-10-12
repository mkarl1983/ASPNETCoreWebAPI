using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllEvaluationContextVars
    {
        public string EvaluationContextOwner { get; set; }
        public string EvaluationContextName { get; set; }
        public string VariableName { get; set; }
        public string VariableType { get; set; }
        public string VariableValueFunction { get; set; }
        public string VariableMethodFunction { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllEvaluationContexts
    {
        public string EvaluationContextOwner { get; set; }
        public string EvaluationContextName { get; set; }
        public string EvaluationFunction { get; set; }
        public string EvaluationContextComment { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllStreamsTransformFunction
    {
        public string RuleOwner { get; set; }
        public string RuleName { get; set; }
        public string ValueType { get; set; }
        public string TransformFunctionName { get; set; }
        public string CustomType { get; set; }
    }
}

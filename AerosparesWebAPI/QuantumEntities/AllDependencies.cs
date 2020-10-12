using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllDependencies
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ReferencedOwner { get; set; }
        public string ReferencedName { get; set; }
        public string ReferencedType { get; set; }
        public string ReferencedLinkName { get; set; }
        public string DependencyType { get; set; }
    }
}

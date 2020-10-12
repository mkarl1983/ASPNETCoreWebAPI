using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllJavaLayouts
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public decimal? Interfaces { get; set; }
        public decimal? InnerClasses { get; set; }
        public decimal? Fields { get; set; }
        public decimal? StaticFields { get; set; }
        public decimal? Methods { get; set; }
        public decimal? StaticMethods { get; set; }
        public decimal? NativeMethods { get; set; }
    }
}

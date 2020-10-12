using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllLibraries
    {
        public string Owner { get; set; }
        public string LibraryName { get; set; }
        public string FileSpec { get; set; }
        public string Dynamic { get; set; }
        public string Status { get; set; }
    }
}

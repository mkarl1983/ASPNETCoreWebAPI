using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSecondaryObjects
    {
        public string IndexOwner { get; set; }
        public string IndexName { get; set; }
        public string SecondaryObjectOwner { get; set; }
        public string SecondaryObjectName { get; set; }
        public string SecondaryObjdataType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllTabStatPrefs
    {
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string PreferenceName { get; set; }
        public string PreferenceValue { get; set; }
    }
}

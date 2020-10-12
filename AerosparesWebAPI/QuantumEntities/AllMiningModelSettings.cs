using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllMiningModelSettings
    {
        public string Owner { get; set; }
        public string ModelName { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public string SettingType { get; set; }
    }
}

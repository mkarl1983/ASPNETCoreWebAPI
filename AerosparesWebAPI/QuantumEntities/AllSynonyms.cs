﻿using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllSynonyms
    {
        public string Owner { get; set; }
        public string SynonymName { get; set; }
        public string TableOwner { get; set; }
        public string TableName { get; set; }
        public string DbLink { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllViews
    {
        public string Owner { get; set; }
        public string ViewName { get; set; }
        public decimal? TextLength { get; set; }
        public string Text { get; set; }
        public decimal? TypeTextLength { get; set; }
        public string TypeText { get; set; }
        public decimal? OidTextLength { get; set; }
        public string OidText { get; set; }
        public string ViewTypeOwner { get; set; }
        public string ViewType { get; set; }
        public string SuperviewName { get; set; }
        public string EditioningView { get; set; }
        public string ReadOnly { get; set; }
    }
}

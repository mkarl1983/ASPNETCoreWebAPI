using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class ColUsage
    {
        public decimal? Obj { get; set; }
        public decimal? Intcol { get; set; }
        public decimal? EqualityPreds { get; set; }
        public decimal? EquijoinPreds { get; set; }
        public decimal? NonequijoinPreds { get; set; }
        public decimal? RangePreds { get; set; }
        public decimal? LikePreds { get; set; }
        public decimal? NullPreds { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}

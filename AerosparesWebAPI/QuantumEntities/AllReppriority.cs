using System;
using System.Collections.Generic;

namespace AerosparesWebAPI.QuantumEntities
{
    public partial class AllReppriority
    {
        public string Sname { get; set; }
        public string PriorityGroup { get; set; }
        public decimal Priority { get; set; }
        public string DataType { get; set; }
        public decimal? FixedDataLength { get; set; }
        public string CharValue { get; set; }
        public string Varchar2Value { get; set; }
        public decimal? NumberValue { get; set; }
        public DateTime? DateValue { get; set; }
        public byte[] RawValue { get; set; }
        public string Gname { get; set; }
        public string NcharValue { get; set; }
        public string Nvarchar2Value { get; set; }
        public string LargeCharValue { get; set; }
    }
}

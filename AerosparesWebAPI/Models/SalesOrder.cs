﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AerosparesWebAPI.Models
{
    public class SalesOrder
    {
        public string SalesNumber { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public decimal UnitPrice { get; set; }
        public string Currency { get; set; }
        public string Employee { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string Serialized { get; set; }
    }
}

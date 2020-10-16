using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AerosparesWebAPI.Models
{
    public class EmployeeQuotes
    {
        public string Employeee { get; set; }
        public int QuotesCount { get; set; }

        public decimal TotalQuotesUnitPrice { get; set; }
    }
}
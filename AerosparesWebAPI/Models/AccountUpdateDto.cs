using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AerosparesWebAPI.Models
{
    public class AccountUpdateDto
    {
        public string AccountFirstName { get; set; }
        public string AccountLastName { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }
    }
}

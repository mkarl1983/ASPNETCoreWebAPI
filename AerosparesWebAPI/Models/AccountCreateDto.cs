using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AerosparesWebAPI.Models
{
    public class AccountCreateDto
    {
        [Required]
        public string AccountFirstName { get; set; }
        [Required]
        public string AccountLastName { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }
    }
}

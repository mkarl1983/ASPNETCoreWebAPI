using System;

namespace AerosparesWebAPI.Models
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string AccountFirstName { get; set; }
        public string AccountLastName { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }

        public string AccountAddress { get; set; }
        public DateTime Created { get; set; }
    }
}

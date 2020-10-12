using System;

namespace AerosparesWebAPI.Entities
{
    public class AccountEntity
    {
        public int Id { get; set; }
        public string AccountFirstName { get; set; }
        public string AccountLastName { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }
        public DateTime Created { get; set; }
    }
}

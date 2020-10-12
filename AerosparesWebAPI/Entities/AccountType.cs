using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AerosparesWebAPI.Entities
{
    public class AccountTypeEntity
    {
        public int Id { get; set; }
        public string AccountType { get; set; }
        public Boolean IsActive { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using AerosparesWebAPI.Entities;

namespace AerosparesWebAPI.Repositories
{
    public class AccountDbContext : DbContext
    {
        public AccountDbContext(DbContextOptions<AccountDbContext> options)
           : base(options)
        {

        }

        public DbSet<AccountEntity> AccountItems { get; set; }

        public DbSet<AccountTypeEntity> AccountTypeItems { get; set; }

    }
}

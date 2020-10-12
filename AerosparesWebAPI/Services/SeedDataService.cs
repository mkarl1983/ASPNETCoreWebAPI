using AerosparesWebAPI.Entities;
using AerosparesWebAPI.Repositories;
using System;
using System.Threading.Tasks;

namespace AerosparesWebAPI.Services
{
    public class SeedDataService : ISeedDataService
    {
        public async Task Initialize(AccountDbContext context)
        {
            context.AccountItems.Add(new AccountEntity() { Id = 1, AccountBalance = 17800, AccountType = "Silver", AccountFirstName = "First Name 1", AccountLastName= "Last Name 1", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 2, AccountBalance = 1100, AccountType = "Bronze", AccountFirstName = "First Name 2", AccountLastName = "Last Name 2", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 3, AccountBalance = 12060, AccountType = "Gold", AccountFirstName = "First Name 3", AccountLastName = "Last Name 3", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 4, AccountBalance = 1300, AccountType = "Gold", AccountFirstName = "First Name 4", AccountLastName = "Last Name 4", Created = DateTime.Now });

            context.AccountItems.Add(new AccountEntity() { Id = 5, AccountBalance = 18000, AccountType = "Silver", AccountFirstName = "First Name 5", AccountLastName = "Last Name 5", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 6, AccountBalance = 1100, AccountType = "Bronze", AccountFirstName = "First Name 6", AccountLastName = "Last Name 6", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 7, AccountBalance = 1200, AccountType = "Gold", AccountFirstName = "First Name 7", AccountLastName = "Last Name 7", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 8, AccountBalance = 1300, AccountType = "Silver", AccountFirstName = "First Name 8", AccountLastName = "Last Name 8", Created = DateTime.Now });

            context.AccountItems.Add(new AccountEntity() { Id = 9, AccountBalance = 700, AccountType = "Silver", AccountFirstName = "First Name 9", AccountLastName = "Last Name 9", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 10, AccountBalance = 13100, AccountType = "Bronze", AccountFirstName = "First Name 10", AccountLastName = "Last Name 10", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 11, AccountBalance = 11200, AccountType = "Gold", AccountFirstName = "First Name 11", AccountLastName = "Last Name 11", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 12, AccountBalance = 1300, AccountType = "Bronze", AccountFirstName = "First Name 12", AccountLastName = "Last Name 12", Created = DateTime.Now });


            context.AccountItems.Add(new AccountEntity() { Id = 13, AccountBalance = 13000, AccountType = "Silver", AccountFirstName = "First Name 13", AccountLastName = "Last Name 13", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 14, AccountBalance = 11600, AccountType = "Bronze", AccountFirstName = "First Name 14", AccountLastName = "Last Name 14", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 15, AccountBalance = 1200, AccountType = "Gold", AccountFirstName = "First Name 15", AccountLastName = "Last Name 15", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 16, AccountBalance = 1300, AccountType = "Gold", AccountFirstName = "First Name 16", AccountLastName = "Last Name 16", Created = DateTime.Now });

            context.AccountItems.Add(new AccountEntity() { Id = 17, AccountBalance = 1000, AccountType = "Silver", AccountFirstName = "First Name 17", AccountLastName = "Last Name 17", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 18, AccountBalance = 1100, AccountType = "Bronze", AccountFirstName = "First Name 18", AccountLastName = "Last Name 18", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 19, AccountBalance = 12300, AccountType = "Gold", AccountFirstName = "First Name 19", AccountLastName = "Last Name 19", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 20, AccountBalance = 1300, AccountType = "Silver", AccountFirstName = "First Name 20", AccountLastName = "Last Name 20", Created = DateTime.Now });

            context.AccountItems.Add(new AccountEntity() { Id = 21, AccountBalance = 10300, AccountType = "Silver", AccountFirstName = "First Name 21", AccountLastName = "Last Name 21", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 22, AccountBalance = 1140, AccountType = "Bronze", AccountFirstName = "First Name 22", AccountLastName = "Last Name 22", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 23, AccountBalance = 1600, AccountType = "Gold", AccountFirstName = "First Name 23", AccountLastName = "Last Name 23", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 24, AccountBalance = 14300, AccountType = "Bronze", AccountFirstName = "First Name 24", AccountLastName = "Last Name 24", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 25, AccountBalance = 13700, AccountType = "Bronze", AccountFirstName = "First Name 25", AccountLastName = "Last Name 25", Created = DateTime.Now });


            context.AccountItems.Add(new AccountEntity() { Id = 26, AccountBalance = 13500, AccountType = "Platinum", AccountFirstName = "First Name 26", AccountLastName = "Last Name 26", Created = DateTime.Now });
            context.AccountItems.Add(new AccountEntity() { Id = 27, AccountBalance = 23700, AccountType = "Platinum", AccountFirstName = "First Name 26", AccountLastName = "Last Name 27", Created = DateTime.Now });


            context.AccountTypeItems.Add(new AccountTypeEntity() { Id = 1, AccountType = "Silver", IsActive = true });

            context.AccountTypeItems.Add(new AccountTypeEntity() { Id = 2, AccountType = "Bronze", IsActive = true });

            context.AccountTypeItems.Add(new AccountTypeEntity() { Id = 3, AccountType = "Gold", IsActive = true });

            await context.SaveChangesAsync();
        }
    }
}

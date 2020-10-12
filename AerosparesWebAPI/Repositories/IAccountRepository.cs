using System.Collections.Generic;
using System.Linq;
using AerosparesWebAPI.Entities;
using AerosparesWebAPI.Models;

namespace AerosparesWebAPI.Repositories
{
    public interface IAccountRepository
    {
        AccountEntity GetSingle(int id);
        void Add(AccountEntity item);
        void Delete(int id);
        AccountEntity Update(int id, AccountEntity item);
        IQueryable<AccountEntity> GetAll(QueryParameters queryParameters);
        IQueryable<AccountTypeEntity> GetAccountTypes(QueryParameters queryParameters);
        ICollection<AccountEntity> GetRandomAccount();
        int Count();

        bool Save();
    }
}

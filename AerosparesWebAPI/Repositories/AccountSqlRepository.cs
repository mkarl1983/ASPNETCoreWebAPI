using AerosparesWebAPI.Entities;
using AerosparesWebAPI.Helpers;
using AerosparesWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace AerosparesWebAPI.Repositories
{
    public class AccountSqlRepository : IAccountRepository
    {
        private readonly AccountDbContext _accountDbContext;

        public AccountSqlRepository(AccountDbContext accountDbContext)
        {
            _accountDbContext = accountDbContext;
        }

        public AccountEntity GetSingle(int id)
        {
            return _accountDbContext.AccountItems.FirstOrDefault(x => x.Id == id);
        }

        public void Add(AccountEntity item)
        {
            _accountDbContext.AccountItems.Add(item);
        }

        public void Delete(int id)
        {
            AccountEntity accountitem = GetSingle(id);
            _accountDbContext.AccountItems.Remove(accountitem);
        }

        public AccountEntity Update(int id, AccountEntity item)
        {
            _accountDbContext.AccountItems.Update(item);
            return item;
        }

        public IQueryable<AccountEntity> GetAll(QueryParameters queryParameters)
        {
            IQueryable<AccountEntity> _allItems = _accountDbContext.AccountItems.OrderBy(queryParameters.OrderBy, queryParameters.IsDescending());

            if (queryParameters.HasQuery())
            {
                _allItems = _allItems
                    .Where(x => x.AccountType.Contains(queryParameters.Query.ToLowerInvariant()) || x.AccountFirstName.ToLowerInvariant().Contains(queryParameters.Query.ToLowerInvariant()));
            }

            return _allItems
                .Skip(queryParameters.PageCount * (queryParameters.Page - 1))
                .Take(queryParameters.PageCount);
        }

        public IQueryable<AccountTypeEntity> GetAccountTypes(QueryParameters queryParameters)
        {
            IQueryable<AccountTypeEntity> _allItems = _accountDbContext.AccountTypeItems.OrderBy(queryParameters.OrderBy, queryParameters.IsDescending());

            if (queryParameters.HasQuery())
            {
                _allItems = _allItems.Where(x => x.IsActive);
            }

            return _allItems;
        }

        public int Count()
        {
            return _accountDbContext.AccountItems.Count();
        }

        public bool Save()
        {
            return (_accountDbContext.SaveChanges() >= 0);
        }

        public ICollection<AccountEntity> GetRandomAccount()
        {
            List<AccountEntity> toReturn = new List<AccountEntity>();

            toReturn.Add(GetRandomItem("Silver"));
            toReturn.Add(GetRandomItem("Bronze"));
            toReturn.Add(GetRandomItem("Gold"));

            return toReturn;
        }

        private AccountEntity GetRandomItem(string type)
        {
            return _accountDbContext.AccountItems
                .Where(x => x.AccountType == type)
                .OrderBy(o => Guid.NewGuid())
                .FirstOrDefault();
        }
    }
}

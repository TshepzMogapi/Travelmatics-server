using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace Travelmatics.Contacts
{
    public class IContactRepository  : IRepository<Contact>
    {
        public IContactRepository()
        {
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public int Count(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> CountAsync(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Delete(Contact entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Contact FirstOrDefault(int id)
        {
            throw new NotImplementedException();
        }

        public Contact FirstOrDefault(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> FirstOrDefaultAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> FirstOrDefaultAsync(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Contact Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> GetAllIncluding(params Expression<Func<Contact, object>>[] propertySelectors)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAllList()
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAllList(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllListAsync(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Contact Insert(Contact entity)
        {
            throw new NotImplementedException();
        }

        public int InsertAndGetId(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAndGetIdAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> InsertAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact InsertOrUpdate(Contact entity)
        {
            throw new NotImplementedException();
        }

        public int InsertOrUpdateAndGetId(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertOrUpdateAndGetIdAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> InsertOrUpdateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact Load(int id)
        {
            throw new NotImplementedException();
        }

        public long LongCount()
        {
            throw new NotImplementedException();
        }

        public long LongCount(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<long> LongCountAsync(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Query<T>(Func<IQueryable<Contact>, T> queryMethod)
        {
            throw new NotImplementedException();
        }

        public Contact Single(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> SingleAsync(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Contact Update(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Contact Update(int id, Action<Contact> updateAction)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> UpdateAsync(int id, Func<Contact, Task> updateAction)
        {
            throw new NotImplementedException();
        }
    }
}

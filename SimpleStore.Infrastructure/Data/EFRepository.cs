using Microsoft.EntityFrameworkCore;
using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleStore.Infrastructure.Data
{
    /// <summary>
    /// "There's some repetition here - couldn't we have some the sync methods call the async?"
    /// https://blogs.msdn.microsoft.com/pfxteam/2012/04/13/should-i-expose-synchronous-wrappers-for-asynchronous-methods/
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly SinpleStoreDbContext _sinpleStoreDbContext;

        public EfRepository(SinpleStoreDbContext dbContext)
        {
            _sinpleStoreDbContext = dbContext;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _sinpleStoreDbContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAllAsync()
        {
            return await _sinpleStoreDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            _sinpleStoreDbContext.Set<T>().Add(entity);
            await _sinpleStoreDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _sinpleStoreDbContext.Entry(entity).State = EntityState.Modified;
            await _sinpleStoreDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _sinpleStoreDbContext.Set<T>().Remove(entity);
            await _sinpleStoreDbContext.SaveChangesAsync();
        }
    }
}

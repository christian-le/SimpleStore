using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SimpleStore.Infrastructure.Interfaces
{
    public interface IAsyncRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        List<T> ListAll();
        T Add(T entity);
        void AddRange(IEnumerable<T> entity);
        T Update(T entity);
        void Delete(T entity);
        void SaveChanges();

        IQueryable<T> Query();
    }
}

using Microsoft.EntityFrameworkCore;
using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SimpleStore.Infrastructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly SinpleStoreDbContext SinpleStoreDbContext;
        protected DbSet<T> DbSet;

        public EfRepository(SinpleStoreDbContext dbContext)
        {
            SinpleStoreDbContext = dbContext;
            DbSet = SinpleStoreDbContext.Set<T>();
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public List<T> ListAll()
        {
            return DbSet.ToList();
        }

        public T Add(T entity)
        {
            DbSet.Add(entity);
            SaveChanges();

            return entity;
        }

        public void AddRange(IEnumerable<T> entity)
        {
            DbSet.AddRange(entity);
            SaveChanges();
        }

        public T Update(T entity)
        {
            DbSet.Update(entity);
            SaveChanges();

            return entity;
        }

        public void Delete(T entity)
        {
            SinpleStoreDbContext.Set<T>().Remove(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            SinpleStoreDbContext.SaveChanges();
        }
    }
}

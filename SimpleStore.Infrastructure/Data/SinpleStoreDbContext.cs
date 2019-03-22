using Microsoft.EntityFrameworkCore;
using SimpleStore.Infrastructure.Entities;

namespace SimpleStore.Infrastructure.Data
{
    public class SinpleStoreDbContext : DbContext
    {
        public SinpleStoreDbContext(DbContextOptions<SinpleStoreDbContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}

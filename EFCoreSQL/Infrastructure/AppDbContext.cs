using EFCoreSQL.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSQL.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DbInitializer.Seed(modelBuilder);
        }
    }
}

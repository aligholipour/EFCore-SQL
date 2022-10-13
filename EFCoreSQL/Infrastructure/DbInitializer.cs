using EFCoreSQL.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSQL.Infrastructure
{
    public static class DbInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Robert C. Martin"
                },
                new Customer
                {
                    Id = 2,
                    Name = "Martin Fowler"
                },
                new Customer
                {
                    Id = 3,
                    Name = "Ali Gholipour"
                }
            );
        }
    }
}

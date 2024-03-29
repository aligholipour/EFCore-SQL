﻿using EFCoreSQL.Domain;
using EFCoreSQL.Domain.SQL;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSQL.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<GetAllCustomer> GetAllCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DbInitializer.Seed(modelBuilder);

            modelBuilder.Entity<GetAllCustomer>()
                .ToView(nameof(GetAllCustomer))
                .HasKey(c => c.Id);
        }

        [DbFunction("NumberOFCustomerOrder", "dbo")]
        public static int NumberOfCustomerOrder(int customerId)
        {
            return 0;
        }
    }
}

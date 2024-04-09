using FMS_Project.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace FMS_Project.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ServiceCheck> ServiceChecks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Location)
                .WithMany()
                .HasForeignKey(c => c.LocationId);

            modelBuilder.Entity<Fridge>()
                .HasOne(f => f.Customer)
                .WithMany(c => c.Fridges)
                .HasForeignKey(f => f.CustomerId);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Location)
                .WithMany()
                .HasForeignKey(e => e.LocationId);

            modelBuilder.Entity<ServiceCheck>()
                .HasOne(sc => sc.Fridge)
                .WithMany(f => f.ServiceChecks)
                .HasForeignKey(sc => sc.FridgeId);
        }
    }
}

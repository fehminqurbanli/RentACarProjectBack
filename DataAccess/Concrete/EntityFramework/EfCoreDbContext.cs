using Core.Entities.Concrete;
using Enitites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCoreDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().
                HasMany(p => p.Cars).WithOne(a => a.Brand).HasForeignKey(a=>a.BrandId);

            modelBuilder.Entity<Color>().
                HasMany(p => p.Cars).WithOne(a => a.Color).HasForeignKey(a => a.ColorId);
            modelBuilder.Entity<Enitites.Concrete.User>().
                HasOne(p => p.Customer).WithOne(a => a.User).HasForeignKey<Customer>(c => c.UserId);

            modelBuilder.Entity<Car>().
                HasOne(p => p.Rental).WithOne(a => a.Car).HasForeignKey<Rental>(c => c.CarId);
            modelBuilder.Entity<Customer>().
                HasOne(a => a.Rental).WithOne(c => c.Customer).HasForeignKey<Rental>(a => a.CustomerId);

            modelBuilder.Entity<Car>().
                HasMany(p => p.CarImages).WithOne(a => a.Car).HasForeignKey(c => c.CarId);

            modelBuilder.Entity<Core.Entities.Concrete.User>().
                HasMany(u => u.UserOperationClaims).WithOne(p => p.User).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<OperationClaim>().
                HasMany(p => p.UserOperationClaims).WithOne(x => x.OperationClaim).HasForeignKey(a => a.OperationClaimId);
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Enitites.Concrete.User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Core.Entities.Concrete.User> UsersClaim { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class VsCarProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MyLocalDb;Database=VsCarProject;Trusted_Connection=True");
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Customer> Customer {  get; set; }
        public DbSet<Rental> Rental { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //The column "Name" for different columns
            modelBuilder.Entity<Car>().Property(c => c.CarName).HasColumnName("Name");
            modelBuilder.Entity<Brand>().Property(b => b.BrandName).HasColumnName("Name");
            modelBuilder.Entity<Color>().Property(o => o.ColorName).HasColumnName("Name");
        }
    }
}

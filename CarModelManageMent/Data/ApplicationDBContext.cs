using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarModelManageMent.Model;

namespace CarModelManageMent.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }

        // DbSet representing the CarModel entity
        public DbSet<CarModel> CarModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Additional model configurations can go here
            // Example: Configure CarModel table name and properties
            modelBuilder.Entity<CarModel>(entity =>
            {
                entity.ToTable("CarModels"); // Maps the DbSet to a specific table
                entity.HasKey(e => e.Id);    // Configure primary key
                entity.Property(e => e.ModelName).IsRequired();
                entity.Property(e => e.ModelCode).IsRequired().HasMaxLength(10);
                entity.Property(e => e.Price).IsRequired().HasColumnType("decimal(18,2)");
                entity.Property(e => e.DateofManufacturing).IsRequired();
            });
        }
    }
}

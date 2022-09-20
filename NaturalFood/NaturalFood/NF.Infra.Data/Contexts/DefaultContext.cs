using Microsoft.EntityFrameworkCore;
using NF.Domain.Entities;
using NF.Infra.Data.Repositories;

namespace NF.Infra.Data.Contexts
{
    public class DefaultContext : DbContext
    {

        public DbSet<Place> Places { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }

        public DefaultContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
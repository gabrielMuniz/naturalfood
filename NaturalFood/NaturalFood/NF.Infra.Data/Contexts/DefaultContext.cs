using Microsoft.EntityFrameworkCore;
using NF.Domain.Entities;
using NF.Infra.Data.Repositories;

namespace NF.Infra.Data.Contexts
{
    public class DefaultContext : DbContext
    {

        public DbSet<Place> Places { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

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
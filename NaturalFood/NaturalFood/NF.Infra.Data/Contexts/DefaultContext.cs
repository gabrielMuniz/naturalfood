using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using NF.Domain.Entities;
using System.Configuration;

namespace NF.Infra.Data.Contexts
{
    public class DefaultContext : DbContext
    {

        public DbSet<Place> Places { get; set; }
        public DbSet<FoodType> FoodTypes { get; set; }

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
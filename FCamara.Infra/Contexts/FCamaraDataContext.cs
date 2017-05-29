using System.Data.Entity;
using FCamara.Domain.Entities;
using FCamara.Infra.Mappings;
using FCamara.Shared;

namespace FCamara.Infra.Contexts
{
    public class FCamaraDataContext : DbContext
    {
        public FCamaraDataContext() : base(Runtime.ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; } 
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }
}

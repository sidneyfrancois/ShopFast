using System.Data.Entity;
using ShopFast.Domain;
using ShopFast.Mapping;

namespace ShopFast.Context
{
    public class FastShopDataContext : DbContext
    {
        public FastShopDataContext()
            :base("FastShopConnectionString")
        {}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
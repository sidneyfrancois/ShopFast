using System.Data.Entity;
using ShopFast.Domain;

namespace ShopFast.Context
{
    public class FastShopDataContext : DbContext
    {
        public FastShopDataContext()
            :base("FastShopConnectionString")
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
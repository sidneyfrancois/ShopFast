using ShopFast.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ShopFast.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            ToTable("Client");

            HasKey(x => x.Id);

            Property(x => x.Nome).HasMaxLength(60).IsRequired();

            HasMany(x => x.Products).WithMany(x => x.Clients).Map(x => x.ToTable("ProductClient"));
        }
    }
}
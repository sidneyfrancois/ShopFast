using ShopFast.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ShopFast.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");

            HasKey(x => x.Id);

            Property(x => x.Name).HasMaxLength(60).IsRequired();

            HasMany(x => x.Products).WithRequired(x => x.Category);
        }
    }
}
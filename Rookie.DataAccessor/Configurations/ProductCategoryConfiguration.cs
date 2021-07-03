using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rookie.DataAccessor.Entities;

namespace Rookie.DataAccessor.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategory");
            builder.HasKey(x => new { x.CategoryId, x.ProductId });
            builder.HasOne(x => x.Product).WithMany(pc => pc.ProductCategories).HasForeignKey(pc => pc.ProductId);
            builder.HasOne(x => x.Category).WithMany(pc => pc.ProductCategories).HasForeignKey(pc => pc.CategoryId);
        }
    }
}

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
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.ToTable("ShoppingCart");
            builder.HasKey(sc => new {sc.ProductId,sc.CreatorId});
            builder.Property(sc => sc.Quantity).IsRequired(true).HasDefaultValue(0);
            builder.Property(sc => sc.Price).IsRequired(true);


            builder.HasOne(p => p.Product).WithOne(sc => sc.ShoppingCart).HasForeignKey<ShoppingCart>(sc => sc.ProductId);
        }
    }
}

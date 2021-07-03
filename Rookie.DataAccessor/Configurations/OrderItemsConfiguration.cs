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
    public class OrderItemsConfiguration : IEntityTypeConfiguration<OrderItems>
    {
        public void Configure(EntityTypeBuilder<OrderItems> builder)
        {
            builder.ToTable("OrderItems");
            builder.HasKey(oi=>oi.Id);
            builder.Property(oi => oi.OrderId).IsRequired(true);
            builder.Property(oi => oi.ProductId).IsRequired(true);
            builder.Property(oi => oi.Price).IsRequired(true);
            builder.Property(oi => oi.Quantity).IsRequired(true).HasDefaultValue(0);

            builder.HasOne(p => p.Products).WithOne(o => o.OrderItems).HasForeignKey<OrderItems>(o => o.ProductId);
        }
    }
}

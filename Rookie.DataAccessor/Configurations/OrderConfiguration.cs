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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(o=>o.Id);
            builder.Property(o => o.OrderITemId).IsRequired(true);
            builder.Property(o => o.CreatorId).IsRequired(true);
            builder.Property(o => o.CustomerId).IsRequired(true);
            builder.Property(o => o.TotalPrice).IsRequired(true);

            builder.HasMany(oi => oi.OrderItems).WithOne(o => o.Order).HasForeignKey(o => o.OrderId);
        }
    }
}

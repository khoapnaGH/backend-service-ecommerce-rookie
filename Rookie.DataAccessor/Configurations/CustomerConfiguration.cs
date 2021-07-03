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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(c=>c.Id);
            builder.Property(c=>c.Name).IsRequired(true);
            builder.Property(c => c.Address).IsRequired(true);
            builder.Property(c => c.Phone).IsRequired(true);

            builder.HasMany(o => o.Orders).WithOne(c => c.Customer).HasForeignKey(c => c.CustomerId);
        }
    }
}

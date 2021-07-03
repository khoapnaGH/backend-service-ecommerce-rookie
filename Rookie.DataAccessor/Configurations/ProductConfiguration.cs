using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rookie.DataAccessor.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rookie.DataAccessor.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired(true);
            builder.Property(p => p.Price).IsRequired(true);

        }
    }
}

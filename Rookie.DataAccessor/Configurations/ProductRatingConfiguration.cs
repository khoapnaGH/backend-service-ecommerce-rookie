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
    public class ProductRatingConfiguration : IEntityTypeConfiguration<ProductRating>
    {
        public void Configure(EntityTypeBuilder<ProductRating> builder)
        {
            builder.ToTable("ProductRating");
            builder.HasKey(pr => new {pr.ProductId, pr.CreatorId });
            builder.Property(pr => pr.Rating).IsRequired(true);

            builder.HasOne(p => p.Product).WithMany(pr => pr.ProductRatings).HasForeignKey(pr=>pr.ProductId);
        }
    }
}

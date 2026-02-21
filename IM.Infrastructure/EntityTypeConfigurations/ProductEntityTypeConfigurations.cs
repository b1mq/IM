using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IM.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IM.Infrastructure.EntityTypeConfigurations
{
    public class ProductEntityTypeConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OriginalPrice)
                .IsRequired()
                .HasColumnType("decimal(10,2)");
            builder.HasOne(x => x.Category)
                .WithMany(x =>x.Products)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}

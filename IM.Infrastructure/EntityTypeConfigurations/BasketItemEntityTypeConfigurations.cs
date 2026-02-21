using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IM.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace IM.Infrastructure.EntityTypeConfigurations
{
    public class BasketItemConfiguration : IEntityTypeConfiguration<BasketItem>
    {
        public void Configure(EntityTypeBuilder<BasketItem> builder)
        {
            builder.HasKey(i => i.Id);

            builder.HasOne(i => i.Basket)
                   .WithMany(b => b.Items)
                   .HasForeignKey(i => i.BasketId);

            builder.HasOne(i => i.Product)
                   .WithMany(p => p.BasketItems)
                   .HasForeignKey(i => i.ProductId);
        }
    }
}

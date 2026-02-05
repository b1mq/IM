using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IM.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace IM.Infrastructure.EntityTypeConfigurations
{
    public  class PromoCodeEntityTypeConfigurations:IEntityTypeConfiguration<PromoCode>
    {
        public void Configure(EntityTypeBuilder<PromoCode> builder)
        {
            // ключ
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id ).ValueGeneratedOnAdd(); // автоинкремент PK
            builder.Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(p => p.IsPercent)
                .IsRequired();
            builder.Property(p => p.DiscountValue)
                .IsRequired();







        }

    }
}

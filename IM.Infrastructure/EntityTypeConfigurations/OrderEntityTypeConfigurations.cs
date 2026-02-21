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
    public class OrderEntityTypeConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);
            builder.HasOne(p => p.User)
                .WithMany()
                .HasForeignKey(p => p.User.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne(p => p.Basket).
                WithMany()
                .HasForeignKey(p => p.Basket.Id);


        }
    }
}

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
    internal class OrderEntityTypeConfigurations : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id); // primary key
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.OrderId)
                .IsRequired();
            builder.Property(p => p.UserId)
                .IsRequired();

        }
    }
}

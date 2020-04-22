using LunchMenu.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Persistence.Configurations
{
    public class FeastOrderConfiguration : BaseConfiguration<FeastOrder>
    {
        public override void Configure(EntityTypeBuilder<FeastOrder> builder)
        {
            base.Configure(builder);

            builder
                .HasOne<Customer>()
                .WithMany(x => x.FeastOrders)
                .HasForeignKey(x => x.CustomerId);

            builder.HasMany<Feast>();
        }
    }
}

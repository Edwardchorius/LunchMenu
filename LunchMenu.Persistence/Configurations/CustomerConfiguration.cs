using LunchMenu.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Persistence.Configurations
{
    public class CustomerConfiguration : BaseConfiguration<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);

            builder.HasKey(c => c.Id);

            builder
                .Property(e => e.OrdersInDays)
                .HasConversion(
                    k => JsonConvert.SerializeObject(k, Formatting.None),
                    v => JsonConvert.DeserializeObject<Dictionary<string, FeastOrder>>(v));
            
        }
    }
}

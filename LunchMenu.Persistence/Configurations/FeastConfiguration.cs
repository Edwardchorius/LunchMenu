using LunchMenu.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Persistence.Configurations
{
    public class FeastConfiguration : BaseConfiguration<Feast>
    {
        public override void Configure(EntityTypeBuilder<Feast> builder)
        {
            base.Configure(builder);

            builder
                .HasIndex(x => x.Name)
                .IsUnique();
        }
    }
}

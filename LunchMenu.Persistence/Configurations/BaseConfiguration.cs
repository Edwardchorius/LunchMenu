using LunchMenu.Domain.Models.Base;
using LunchMenu.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pluralize.NET;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Persistence.Configurations
{
    public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : class, IDataModel
    {
        protected static readonly Pluralizer Pluralizer = new Pluralizer();

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(Pluralizer.Pluralize(typeof(TEntity).Name));

            builder
                .Property<bool>(nameof(IDeletable.IsDeleted))
                .IsRequired(true)
                .HasDefaultValue(false);

            builder
                .Property<DateTime?>(nameof(IDeletable.DeletedOn))
                .IsRequired(false);

            builder
                .HasQueryFilter(x => EF.Property<bool>(x, nameof(IDeletable.IsDeleted)) == false);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseHiLo();
        }
    }
}

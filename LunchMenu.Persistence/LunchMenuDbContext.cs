using LunchMenu.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LunchMenu.Persistence
{
    public class LunchMenuDbContext : DbContext
    {
        public LunchMenuDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        public override async Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default)
        {
            var now = DateTime.UtcNow;

            UpdateCreatedEntities(now);

            var result = await base.SaveChangesAsync(cancellationToken);
            return result;
        }

        public override int SaveChanges()
        {
            var now = DateTime.UtcNow;

            UpdateCreatedEntities(now);

            var result = base.SaveChanges();
            return result;
        }

        private void UpdateCreatedEntities(DateTime time)
        {
            var entries = ChangeTracker
                .Entries<IDataModel>();

            var createdEntities = entries.Where(e => e.State == EntityState.Added);

            foreach (var entry in createdEntities)
            {
                entry.Property(nameof(IDataModel.CreatedOn)).CurrentValue = time;
                entry.Property(nameof(IDataModel.ModifiedOn)).CurrentValue = time;
            }
        }
    }
}

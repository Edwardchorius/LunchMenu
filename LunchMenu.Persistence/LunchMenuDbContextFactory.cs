using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LunchMenu.Persistence
{
    public class LunchMenuDbContextFactory : IDesignTimeDbContextFactory<LunchMenuDbContext>
    {
        public LunchMenuDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LunchMenuDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=lunchmenu;Trusted_Connection=True;");

            return new LunchMenuDbContext(optionsBuilder.Options);
        }
    }
}

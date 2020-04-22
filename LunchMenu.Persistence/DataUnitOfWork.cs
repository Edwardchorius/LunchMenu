using LunchMenu.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Persistence
{
    internal class DataUnitOfWork : IDataUnitOfWork
    {
        private readonly LunchMenuDbContext _dbContext;
        public DataUnitOfWork(LunchMenuDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}

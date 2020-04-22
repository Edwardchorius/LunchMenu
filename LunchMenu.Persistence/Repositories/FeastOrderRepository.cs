using LunchMenu.Application.Interfaces.Repositories;
using LunchMenu.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Persistence.Repositories
{
    public class FeastOrderRepository : IFeastOrderRepository
    {
        private readonly LunchMenuDbContext _dbContext;

        public FeastOrderRepository(LunchMenuDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<FeastOrder> AddAsync(FeastOrder entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FeastOrder> All()
        {
            throw new NotImplementedException();
        }

        public Task<FeastOrder> DeleteAsync(FeastOrder entity)
        {
            throw new NotImplementedException();
        }

        public FeastOrder FindById(long id, bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<FeastOrder> GetAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}

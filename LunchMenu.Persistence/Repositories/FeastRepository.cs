using LunchMenu.Application.Interfaces.Repositories;
using LunchMenu.Domain.Models;
using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Persistence.Repositories
{
    public class FeastRepository : IFeastRepository
    {
        private readonly LunchMenuDbContext _dbContext;
        public FeastRepository(LunchMenuDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<Feast> AddAsync(Feast entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Feast> All()
        {
            throw new NotImplementedException();
        }

        public Task<Feast> DeleteAsync(Feast entity)
        {
            throw new NotImplementedException();
        }

        public Feast FindById(long id, bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<Feast> GetAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}

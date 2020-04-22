using LunchMenu.Application.Interfaces.Repositories;
using LunchMenu.Application.Interfaces.Repositories.Base;
using LunchMenu.Domain.Models;
using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Persistence.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly LunchMenuDbContext _dbContext;
        public CustomerRepository(LunchMenuDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Customer> AddAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> All()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> DeleteAsync(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer FindById(long id, bool isDeleted = false)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}

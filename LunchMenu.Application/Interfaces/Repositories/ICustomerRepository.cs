using LunchMenu.Application.Interfaces.Repositories.Base;
using LunchMenu.Domain.Models;
using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Application.Interfaces.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Task<Customer> FindByUsername(string username);
    }
}

using LunchMenu.Application.Interfaces.Repositories.Base;
using LunchMenu.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Application.Interfaces.Repositories
{
    public interface IFeastOrderRepository : IGenericRepository<FeastOrder>
    {
        Task<IEnumerable<FeastOrder>> GetByUsername(string username);
    }
}

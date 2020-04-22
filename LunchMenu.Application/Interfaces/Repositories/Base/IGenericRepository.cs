using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Application.Interfaces.Repositories.Base
{
    public interface IGenericRepository<T> where T : class, IDataModel
    {
        IEnumerable<T> All();

        Task<T> AddAsync(T entity);

        Task<T> DeleteAsync(T entity);
        Task<T> GetAsync(long id);
        T FindById(long id, bool isDeleted = false);
    }
}

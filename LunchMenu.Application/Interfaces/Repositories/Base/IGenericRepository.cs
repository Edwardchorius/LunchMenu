using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Application.Interfaces.Repositories.Base
{
    public interface IGenericRepository<T> where T : class, IDataModel
    {
        IEnumerable<T> All();

        void Add(T entity);

        void Delete(T entity);
    }
}

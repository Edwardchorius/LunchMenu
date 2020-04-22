using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Application.Interfaces
{
    public interface IDataUnitOfWork
    {

        int SaveChanges();
        Task SaveChangesAsync();
    }
}

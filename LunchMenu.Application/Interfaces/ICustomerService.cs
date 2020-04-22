using LunchMenu.Application.InputModels.Login;
using LunchMenu.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Application.Interfaces
{
    public interface ICustomerService
    {
        bool Login(LoginInput loginInput);
    }
}

using LunchMenu.Application.InputModels.Login;
using LunchMenu.Application.Interfaces;
using LunchMenu.Application.Interfaces.Repositories;
using LunchMenu.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchMenu.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IHashingService _hashingService;
        private readonly IFeastOrderRepository _feastOrderRepository;

        public CustomerService(
            ICustomerRepository customerRepository,
            IHashingService hashingService,
            IFeastOrderRepository feastOrderRepository)
        {
            _customerRepository = customerRepository;
            _hashingService = hashingService;
            _feastOrderRepository = feastOrderRepository;
        }

        public bool Login(LoginInput loginInput)
        {
            string hashIncomingPassword = _hashingService.GenerateHash(loginInput.Password);
            var customerToCompare = _customerRepository.FindByUsername(loginInput.Username).Result;

            if((customerToCompare != null && hashIncomingPassword == customerToCompare.Password))
            {
                return true;
            }

            return false;
        }     
    }
}

using LunchMenu.Application.InputModels.Login;
using LunchMenu.Application.Interfaces;
using LunchMenu.Web.Models;
using LunchMenu.Web.Models.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchMenu.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginRequest request)
        {
            if (ModelState.IsValid)
            {
                var loginInput = new LoginInput("Edwardcho", "RandomPassword");

                if (_customerService.Login(loginInput))
                {
                    return Ok();
                }
            }

            return new NotFoundResult();
        }

        //[HttpPost]
        //public async Task<ActionResult> MyOrders()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var orders = _customerService.Orders();
        //    }

        //    return new NotFoundResult();
        //}
    }
}

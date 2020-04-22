using LunchMenu.Application.Services;
using LunchMenu.Domain.Enums;
using LunchMenu.Domain.Models;
using LunchMenu.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Persistence.Services
{
    public class DataSeedingService : IDataSeedingService
    {
        private readonly LunchMenuDbContext _dbContext;
        public DataSeedingService(LunchMenuDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            SeedUsers();
        }

        private void SeedUsers()
        {
            if (_dbContext.Customers.Any())
            {
                return;
            }

            var feastOrder = new FeastOrder()
            {
                Feasts = new List<Feast>()
                            {
                                new Feast()
                                {
                                    Name = "Tarator",
                                    Type = FeastType.Appetizer
                                },
                                new Feast()
                                {
                                    Name = "Bob s Nadenica",
                                    Type = FeastType.Main
                                },
                                new Feast()
                                {
                                    Name = "Cedeno mlqko",
                                    Type = FeastType.Dessert
                                }
                            }
            };

            var hashedPassword = new HashingService().GenerateHash("RandomPassword");

            var customer = new Customer()
            {
                FirstName = "Eduard",
                LastName = "Vaklinov",
                Type = CustomerType.Ordinary,
                Username = "Edwardcho",
                Password = hashedPassword,
                FeastOrders = new List<FeastOrder>()
                    {
                        feastOrder
                    },
                OrdersInDays = new Dictionary<string, FeastOrder>()
                    {
                        { "Saturday", feastOrder}
                    }
            };

            _dbContext.Customers.AddAsync(customer);
            _dbContext.SaveChanges();
        }
    }
}

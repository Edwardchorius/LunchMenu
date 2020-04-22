using LunchMenu.Domain.Enums;
using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Domain.Models
{
    public class Customer : BaseDataModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType Type { get; set; }
        public string Username { get; set; }
        public ICollection<FeastOrder> FeastOrders { get; set; }
        public Dictionary<string, FeastOrder> OrdersInDays { get; set; }
    }
}

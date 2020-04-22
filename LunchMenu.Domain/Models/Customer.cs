using LunchMenu.Domain.Enums;
using LunchMenu.Domain.Models.Base;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LunchMenu.Domain.Models
{
    public class Customer : BaseDataModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public CustomerType Type { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public ICollection<FeastOrder> FeastOrders { get; set; }
        public Dictionary<string, FeastOrder> OrdersInDays { get; set; }

    }
}

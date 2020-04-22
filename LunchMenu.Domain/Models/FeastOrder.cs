using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Domain.Models
{
    public class FeastOrder : BaseDataModel
    { 
        public long CustomerId { get; set; }
        public ICollection<Feast> Feasts { get; set; }
    }
}

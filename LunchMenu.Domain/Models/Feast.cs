using LunchMenu.Domain.Enums;
using LunchMenu.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Domain.Models
{
    public class Feast : BaseDataModel
    {
        public string Name { get; set; }
        public FeastType Type { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Domain.Models.Base
{
    public interface IDataModel
    {
        long Id { get; }
        string CreatedBy { get; set; }
        DateTime CreatedOn { get; set; }

        string ModifiedBy { get; set; }
        DateTime? ModifiedOn { get; set; }
    }
}

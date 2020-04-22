using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Persistence.Interfaces
{
    interface IDeletable
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}

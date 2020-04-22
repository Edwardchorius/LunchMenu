using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Domain.Models.Base
{
    public abstract class BaseDataModel : IDataModel
    {
        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}

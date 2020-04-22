using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Application.Exceptions
{
    public abstract class ApplicationException : Exception
    {
        protected ApplicationException(string message)
            : base(message)
        {
        }

        public ApplicationException()
            : base()
        {
        }
    }
}

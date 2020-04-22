using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Application.Exceptions
{
    public class AuthenticationApplicationException : ApplicationException
    {
        public AuthenticationApplicationException(string message)
            : base(message)
        {
        }

        public AuthenticationApplicationException()
            : base()
        {
        }
    }
}

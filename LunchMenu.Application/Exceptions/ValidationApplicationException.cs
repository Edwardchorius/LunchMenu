using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace LunchMenu.Application.Exceptions
{
    public class ValidationApplicationException : ApplicationException
    {
        public ValidationApplicationException()
            : base("Validation failures have occurred.")
        {
        }

        public ValidationApplicationException(IReadOnlyCollection<ValidationFailure> failures)
            : this()
        {
            Failures = failures;
        }

        public IReadOnlyCollection<ValidationFailure> Failures { get; }
    }
}

using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchMenu.Web.Validation
{
    public class ValidationErrorResponse
    {
        public ValidationErrorResponse(string message, IReadOnlyDictionary<string, string[]> failures)
        {
            Message = message;
            Failures = failures?.SelectMany(x =>
                x.Value?.Select(v =>
                    new FailureResponse
                    {
                         Name = x.Key,
                         Reason = v,
                    }));
        }

        public ValidationErrorResponse(string message, IReadOnlyCollection<ValidationFailure> failures)
        {
            Message = message;
            Failures = failures?.Select(x => new FailureResponse { Name = x.PropertyName, Reason = x.ErrorMessage });
        }

        public string Message { get; set; }
        public IEnumerable<FailureResponse> Failures { get; set; }
    }
}

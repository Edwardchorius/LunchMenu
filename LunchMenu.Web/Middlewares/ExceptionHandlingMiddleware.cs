using LunchMenu.Application.Exceptions;
using LunchMenu.Domain.Exceptions;
using LunchMenu.Web.Validation;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunchMenu.Web.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (ValidationApplicationException ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
            catch (ValidationDomainException ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
            catch (AuthenticationApplicationException ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, ValidationApplicationException exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.Body.FlushAsync();

            var response = new ValidationErrorResponse(exception.Message, exception.Failures);

            var result = JsonConvert.SerializeObject(response);
            await context.Response.WriteAsync(result);
        }

        private async Task HandleExceptionAsync(HttpContext context, ValidationDomainException exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.Body.FlushAsync();

            var response = new ValidationErrorResponse(
                exception.Message,
                new Dictionary<string, string[]>
                {
                    { exception.PropertyName, new[] { exception.Message } }
                });

            var result = JsonConvert.SerializeObject(response);
            await context.Response.WriteAsync(result);
        }

        private async Task HandleExceptionAsync(HttpContext context, AuthenticationApplicationException exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.Body.FlushAsync();

            var response = new ValidationErrorResponse(
                exception.Message,
                new Dictionary<string, string[]>());

            var result = JsonConvert.SerializeObject(response);
            await context.Response.WriteAsync(result);
        }
    }
}

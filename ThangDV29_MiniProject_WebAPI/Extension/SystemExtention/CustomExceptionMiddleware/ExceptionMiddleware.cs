using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;
using ThangDV29_MiniProject_WebAPI.Extention;

namespace ThangDV29_MiniProject_WebAPI.CustomExceptionMiddleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerManager _logger;
        public ExceptionMiddleware(RequestDelegate next, ILoggerManager logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong: {ex}");
                await HandleExceptionAsync(httpContext);
            }
        }

        private Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return context.Response.WriteAsJsonAsync(new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Message = "Error from the custom middleware of ThangDepChai2k5."
            });
        }
    }
}

// Middlewares/ExceptionHandlingMiddleware.cs
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using ProcessTracker.Exceptions;
using Serilog.Context;

namespace ProcessTracker.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, _logger);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, ILogger<ExceptionHandlingMiddleware> logger)
        {
            var correlationId = context.Items["CorrelationId"]?.ToString() ?? "Unknown";
            context.Response.ContentType = "application/json";

            var problemDetails = new ProblemDetails
            {
                Instance = context.Request.Path,
                Extensions = new Dictionary<string, object?>
                {
                    { "CorrelationId", correlationId },
                    { "Timestamp", DateTime.UtcNow }
                }
            };

            switch (exception)
            {
                case ValidationException validationEx:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    problemDetails.Status = StatusCodes.Status400BadRequest;
                    problemDetails.Title = "Validation Failed";
                    problemDetails.Detail = "One or more validation errors occurred.";
                    problemDetails.Extensions["errors"] = validationEx.Errors;

                    logger.LogWarning(
                        "Validation Exception | CorrelationId: {CorrelationId} | Errors: {@Errors}",
                        correlationId,
                        validationEx.Errors);
                    break;

                case NotFoundException notFoundEx:
                    context.Response.StatusCode = StatusCodes.Status404NotFound;
                    problemDetails.Status = StatusCodes.Status404NotFound;
                    problemDetails.Title = "Not Found";
                    problemDetails.Detail = notFoundEx.Message;

                    logger.LogWarning(
                        "Not Found Exception | CorrelationId: {CorrelationId} | Message: {Message}",
                        correlationId,
                        notFoundEx.Message);
                    break;

                case InvalidOperationException invalidOpEx:
                    context.Response.StatusCode = StatusCodes.Status409Conflict;
                    problemDetails.Status = StatusCodes.Status409Conflict;
                    problemDetails.Title = "Conflict";
                    problemDetails.Detail = invalidOpEx.Message;

                    logger.LogWarning(
                        "Invalid Operation Exception | CorrelationId: {CorrelationId} | Message: {Message}",
                        correlationId,
                        invalidOpEx.Message);
                    break;

                case Microsoft.EntityFrameworkCore.DbUpdateException dbEx:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    problemDetails.Status = StatusCodes.Status500InternalServerError;
                    problemDetails.Title = "Database Error";
                    problemDetails.Detail = "An error occurred while updating the database.";

                    logger.LogError(
                        dbEx,
                        "Database Update Exception | CorrelationId: {CorrelationId}",
                        correlationId);
                    break;

                case Microsoft.Data.SqlClient.SqlException sqlEx:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    problemDetails.Status = StatusCodes.Status500InternalServerError;
                    problemDetails.Title = "Database Connection Error";
                    problemDetails.Detail = "An error occurred while connecting to the database.";

                    logger.LogError(
                        sqlEx,
                        "SQL Exception | CorrelationId: {CorrelationId}",
                        correlationId);
                    break;

                case ArgumentNullException argNullEx:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    problemDetails.Status = StatusCodes.Status400BadRequest;
                    problemDetails.Title = "Invalid Argument";
                    problemDetails.Detail = argNullEx.Message;

                    logger.LogWarning(
                        "Argument Null Exception | CorrelationId: {CorrelationId} | Message: {Message}",
                        correlationId,
                        argNullEx.Message);
                    break;

                case ArgumentException argEx:
                    context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    problemDetails.Status = StatusCodes.Status400BadRequest;
                    problemDetails.Title = "Invalid Argument";
                    problemDetails.Detail = argEx.Message;

                    logger.LogWarning(
                        "Argument Exception | CorrelationId: {CorrelationId} | Message: {Message}",
                        correlationId,
                        argEx.Message);
                    break;

                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    problemDetails.Status = StatusCodes.Status500InternalServerError;
                    problemDetails.Title = "Internal Server Error";
                    problemDetails.Detail = "An unexpected error occurred. Please try again later.";

                    logger.LogError(
                        exception,
                        "Unhandled Exception | CorrelationId: {CorrelationId} | Exception Type: {ExceptionType}",
                        correlationId,
                        exception.GetType().Name);
                    break;
            }

            var response = JsonSerializer.Serialize(problemDetails, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            return context.Response.WriteAsync(response);
        }
    }
}
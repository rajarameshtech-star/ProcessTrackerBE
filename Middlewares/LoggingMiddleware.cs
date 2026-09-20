// Middlewares/LoggingMiddleware.cs
using Serilog.Context;

namespace ProcessTracker.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<LoggingMiddleware> _logger;

        public LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var correlationId = Guid.NewGuid().ToString();
            using (LogContext.PushProperty("CorrelationId", correlationId))
            {
                var request = context.Request;
                var requestBody = string.Empty;

                // Capture request body for POST/PUT
                if (request.Method == "POST" || request.Method == "PUT")
                {
                    request.EnableBuffering();
                    using (var reader = new StreamReader(request.Body))
                    {
                        requestBody = await reader.ReadToEndAsync();
                        request.Body.Position = 0;
                    }
                }

                _logger.LogInformation(
                    "HTTP Request: {Method} {Path} | CorrelationId: {CorrelationId} | RequestBody: {RequestBody}",
                    request.Method,
                    request.Path,
                    correlationId,
                    requestBody);

                var originalBodyStream = context.Response.Body;

                using (var responseBody = new MemoryStream())
                {
                    context.Response.Body = responseBody;

                    try
                    {
                        await _next(context);

                        var response = context.Response;
                        response.Body.Seek(0, SeekOrigin.Begin);
                        var responseBodyText = await new StreamReader(response.Body).ReadToEndAsync();
                        response.Body.Seek(0, SeekOrigin.Begin);

                        _logger.LogInformation(
                            "HTTP Response: {StatusCode} {Path} | CorrelationId: {CorrelationId} | ResponseTime: {ResponseTime}ms",
                            response.StatusCode,
                            request.Path,
                            correlationId,
                            context.Items["ResponseTime"] ?? 0);

                        await responseBody.CopyToAsync(originalBodyStream);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError(
                            ex,
                            "HTTP Request Exception: {Method} {Path} | CorrelationId: {CorrelationId}",
                            request.Method,
                            request.Path,
                            correlationId);

                        throw;
                    }
                }
            }
        }
    }
}
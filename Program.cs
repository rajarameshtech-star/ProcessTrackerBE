// Program.cs - UPDATE TO ADD CORRELATION ID AND EXCEPTION HANDLING MIDDLEWARE

using Serilog;
using Serilog.Settings.Configuration;
using ProcessTracker.Data;
using ProcessTracker.Interfaces.RepositoryInterfaces;
using ProcessTracker.Interfaces.ServiceInterfaces;
using ProcessTracker.Repositories;
using ProcessTracker.Services;
using ProcessTracker.Middlewares;
using Microsoft.EntityFrameworkCore;
using Serilog.Extensions.Hosting;

// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build())
    .CreateLogger();

try
{
    Log.Information("Starting ProcessTracker API...");

    var builder = WebApplication.CreateBuilder(args);

    // Add Serilog to DI
    builder.Host.UseSerilog();

    // Add services to the container
    builder.Services.AddControllers();

    // Database Configuration
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

    // Repository Dependency Injection
    builder.Services.AddScoped<IApplicationRepository, ApplicationRepository>();
    builder.Services.AddScoped<IRecordRepository, RecordRepository>();
    builder.Services.AddScoped<IProcessDefinitionRepository, ProcessDefinitionRepository>();

    // Service Dependency Injection
    builder.Services.AddScoped<IValidationService, ValidationService>();
    builder.Services.AddScoped<IRecordService, RecordService>();
    builder.Services.AddScoped<IApplicationService, ApplicationService>();
    builder.Services.AddScoped<IProcessDefinitionService, ProcessDefinitionService>();

    // CORS Configuration
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowAngularApp", policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
    });

    // Swagger/OpenAPI
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Add Correlation ID Middleware (before others)
    app.Use(async (context, next) =>
    {
        var correlationId = Guid.NewGuid().ToString();
        context.Items["CorrelationId"] = correlationId;
        context.Response.Headers.Add("X-Correlation-ID", correlationId);
        await next();
    });

    // Add Exception Handling Middleware
    app.UseMiddleware<ExceptionHandlingMiddleware>();

    // Add Logging Middleware
    app.UseMiddleware<LoggingMiddleware>();

    // Configure the HTTP request pipeline
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    // CORS Middleware
    app.UseCors("AllowAngularApp");

    app.UseAuthorization();

    app.MapControllers();

    Log.Information("ProcessTracker API started successfully");
    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "ProcessTracker API terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
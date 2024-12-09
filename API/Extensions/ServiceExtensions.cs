
using Application.LoggerService.LoggerManager;
using Application.Services.Contract;
using Application.Services.Implementation;
using Infrastructure.DataAccess;
using Infrastructure.Repository.Contract;
using Infrastructure.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ServiceExtensions
{
    // Configure CORS for origins, methods or headers the service allows.
    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
        });
    
    // IIS Configuration
    public static void ConfigureIISIntegration(this IServiceCollection services) =>
        services.Configure<IISOptions > (_ =>
        {
            
        });

    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();
    
    public static void ConfigureSqliteContext(this IServiceCollection services, IConfiguration configuration) =>
        services.AddDbContext<RepositoryContext>(opts =>
            opts.UseSqlite(configuration.GetConnectionString("sqliteConnection")));

    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();

    public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();
}
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestesUnitarios.Infraestructure.Context;

namespace TestesUnitarios.Api.Configurations
{
    public static class DatabaseConfig
    {
        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration config)
        {
            if(services == null) throw new NullReferenceException(nameof(services));

            services.AddDbContext<DatabaseConnection>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("dev"), opt => opt.MigrationsAssembly("TestesUnitarios.Api"));
                opt.LogTo(System.Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information); 
            });
        }
    }
}
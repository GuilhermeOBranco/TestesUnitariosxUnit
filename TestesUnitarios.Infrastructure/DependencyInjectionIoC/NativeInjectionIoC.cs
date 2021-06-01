using System;
using Microsoft.Extensions.DependencyInjection;
using TestesUnitarios.Infraestructure.Interfaces;
using TestesUnitarios.Infraestructure.Repository;

namespace TestesUnitarios.Infraestructure.DependencyInjectionIoC
{
    public static class NativeInjectionIoC
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));
        }
    }
}
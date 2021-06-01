using System;
using Microsoft.Extensions.DependencyInjection;
using TestesUnitarios.Infraestructure.DependencyInjectionIoC;

namespace TestesUnitarios.Api.Configurations
{
    public static class DependencyInjection
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            if(services == null) throw new NullReferenceException(nameof(services));
            NativeInjectionIoC.RegisterService(services);
        }
    }
}
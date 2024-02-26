using Microsoft.Extensions.DependencyInjection;
using Store.Application.JWT;
using System.Reflection;

namespace Store.Application
{
    public static class ApplicationServicesRegisteration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddScoped<JWTService>();

            return services;
        }
    }
}

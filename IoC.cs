using LoginInformation.Services;
using Microsoft.Extensions.DependencyInjection;


namespace LoginInformation
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();

            return services;
        }
    }
}

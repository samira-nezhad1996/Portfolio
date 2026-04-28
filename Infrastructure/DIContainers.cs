using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Application.Services.AboutMe;

namespace Infrastructure
{
    public static class DIContainers
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAboutMeService, AboutMeService>();
        }
    }
}

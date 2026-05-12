using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Application.Services.AboutMe;
using Application.Services.User;
using Application.Repositories;
using Application.Services.LastWorks;

namespace Infrastructure
{
    public static class DIContainers
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IAboutMeService, AboutMeService>();
            services.AddScoped<IUserService, UserService >();
            services.AddScoped<ILastWorksService, LastWorksService >();
        }
    }
}

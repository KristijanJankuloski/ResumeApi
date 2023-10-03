using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Resume.DataAccess.Context;
using Resume.DataAccess.Repository.Implementations;
using Resume.DataAccess.Repository.Interfaces;
using Resume.Services.AuthService.Implementations;
using Resume.Services.AuthService.Interfaces;
using Resume.Services.Implementations;
using Resume.Services.Interfaces;

namespace Resume.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
        }

        public static void InjectRepositories(this IServiceCollection services)
        {
            services.AddTransient<IResumeRepository, ResumeRepository>();
            services.AddTransient<ISkillRepository, SkillRepository>();
        }

        public static void InjectServices(this IServiceCollection services)
        {
            services.AddTransient<ITokenService, TokenService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IResumeService, ResumeService>();
            services.AddScoped<ISkillService, SkillService>();
        }
    }
}

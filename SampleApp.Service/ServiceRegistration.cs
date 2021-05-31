using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SampleApp.Service.Contracts.Repositories;
using SampleApp.Service.Contracts.Services;
using SampleApp.Service.Repositories;
using SampleApp.Service.Services.UserRoles;
using SampleApp.Service.Services.Users;
using System.Reflection;

namespace SampleApp.Service
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddServiceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SampleAppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRoleRepository, UserRoleRepository>();
            services.AddTransient<IUserRoleService, UserRoleService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}

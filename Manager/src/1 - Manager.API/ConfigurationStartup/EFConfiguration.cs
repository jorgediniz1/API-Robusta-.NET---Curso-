using Manager.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Manager.API.ConfigurationStartup
{
    public static class EFConfiguration
    {
        public static void AddEFConfigurations(this IServiceCollection services, IConfiguration config)
        {
            //Add services DbContext 

            services.AddDbContext<ManagerContext>(x => x.UseSqlServer(
                config.GetConnectionString("DefaultConnection")
            ));
        }
    }
}
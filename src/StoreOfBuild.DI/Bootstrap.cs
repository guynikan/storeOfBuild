using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StoreOfBuild.Data;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection){

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connection));
                
        }
    }
}
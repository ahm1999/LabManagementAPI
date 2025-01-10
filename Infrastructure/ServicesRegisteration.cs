
using Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServicesRegisteration
    {
        public static void RegisterDb(this IServiceCollection services,string configuration) {

            services.AddDbContext<ApplicationDBContext>( options => options.UseSqlServer(configuration));


            //services.AddAuthorization();

        }
    }
}

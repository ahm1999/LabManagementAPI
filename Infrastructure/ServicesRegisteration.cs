
using Application.ServiceInterfaces;
using Infrastructure.Identity;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.DependencyInjection;

//using Microsoft.AspNetCore.Http.Abstractions;
namespace Infrastructure
{
    public static class ServicesRegisteration
    {
        //public static void RegisterUtil(this IServiceCollection services) {
        //    //services.Add

        //}

        public static void RegisterEntitiesServices(this IServiceCollection services) {
            services.AddScoped<ILabTestService, LabTestService>();
        }
        public static void RegisterDb(this IServiceCollection services,string configuration) {

            services.AddDbContext<ApplicationDBContext>( options => options.UseSqlServer(configuration));


            //services.AddAuthorization();

        }
    }
}

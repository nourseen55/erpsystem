

namespace Erp.Web.DependencyInjection
{
    public static  class DependencyInjection
    {
        public static IServiceCollection InjectionServices(this IServiceCollection services, WebApplicationBuilder builder)
        {
            var connectionstring = builder.Configuration.GetConnectionString("DefaultConncetion");
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseLazyLoadingProxies().UseSqlServer(connectionstring));

            return services;
        }
    }
}

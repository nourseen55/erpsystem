
using Erp.BL.CategoryServiceBL;

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
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<SeedRoleServiceBL>();
            builder.Services.AddScoped<DefaultRole>();
            builder.Services.AddScoped<UnitSeedServicesBL>();
            builder.Services.AddScoped<DefaultUnit>();
            builder.Services.AddScoped<CurrencySeedServicesBL>();
            builder.Services.AddScoped<DefaultCurrency>();
            builder.Services.AddScoped<ICategoriesBL, CategoriesBL>();

            return services;
        }
    }
}


using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.InjectionServices(builder);

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    try
    {
        var serviceProvider = scope.ServiceProvider; 

        var defaultroleServices = serviceProvider.GetRequiredService<DefaultRole>();
        var defaultunitServices = serviceProvider.GetRequiredService<DefaultUnit>();
        var defaultcurrencyServices = serviceProvider.GetRequiredService<DefaultCurrency>();

        await defaultroleServices.SeedDefaultRoles();
        await defaultunitServices.SeedDefaultUnit();
        await defaultcurrencyServices.SeedDefaultCurrency();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error Seeding: {ex.Message} - {ex.Source}");
        throw;
    }
}


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

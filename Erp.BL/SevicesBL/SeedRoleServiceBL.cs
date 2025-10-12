

namespace Erp.BL.SevicesBL
{
    public class SeedRoleServiceBL(RoleManager<IdentityRole> roleManager)
    {
        public async Task SeedDefaultRoles()
        {
            if (!await roleManager.Roles.AnyAsync(r => r.Name == (RoleConstant.DefaultRole)))
                await roleManager.CreateAsync(new IdentityRole ( RoleConstant.DefaultRole ));

        }
    }
}
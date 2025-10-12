


namespace Erp.BL.Seeds
{
    public class DefaultRole(SeedRoleServiceBL seedRoleService )
    {
        public async Task SeedDefaultRoles()
        {
            await seedRoleService.SeedDefaultRoles();
        }
    }
}

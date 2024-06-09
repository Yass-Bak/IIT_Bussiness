using Microsoft.AspNetCore.Identity;
using ProjetPFA.Contants;

namespace ProjetPFA.Seeds
{
    public static class DefaultRoles
    {
        public static async Task SeedAsync(RoleManager<IdentityRole> roleManger)
        {
            if (!roleManger.Roles.Any())
            {
                await roleManger.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
                await roleManger.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
                await roleManger.CreateAsync(new IdentityRole(Roles.Basic.ToString()));
                await roleManger.CreateAsync(new IdentityRole(Roles.ResopnsableRH.ToString()));
                await roleManger.CreateAsync(new IdentityRole(Roles.ResopnsableMarketing.ToString()));
                await roleManger.CreateAsync(new IdentityRole(Roles.ResopnsableAdministration.ToString()));
            }
        }
    }
}
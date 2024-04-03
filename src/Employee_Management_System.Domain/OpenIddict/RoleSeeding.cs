using Employee_Management_System.Permissions;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Users;

namespace Employee_Management_System.OpenIddict
{
    public class RoleSeeding : IDataSeedContributor, ITransientDependency
    {
       private readonly IdentityRoleManager _roleManager;
        private readonly IdentityUserManager _userManager;


        public RoleSeeding(IdentityRoleManager roleManager, IdentityUserManager userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
          
            /*Admin role seeding*/
            var admin = await _roleManager.FindByNameAsync("admin");
            if (admin == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "admin"));
            }

            var hr = await _roleManager.FindByNameAsync("hr");
            if (hr == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "hr"));
            }


            /*Creating user of admin and seeding the data*/

            var user = new IdentityUser(Guid.NewGuid(), "ranjay", "ranjay@admin.com");


            var admin_name = await _userManager.CreateAsync(user, "Ranjay1!");

            if (admin_name.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "admin");
            }
            else
            {
                throw new Exception("Failed to create user");
            }
        


        }
    }
}

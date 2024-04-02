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
    public class Roles : IDataSeedContributor, ITransientDependency
    {
       private readonly IdentityRoleManager _roleManager;
        private readonly IPermissionManager _permissionManager;
        //private readonly ICurrentUser _currentUser;
        private readonly IdentityUserManager _userManager;


        public Roles(IdentityRoleManager roleManager, IPermissionManager permissionManager, IdentityUserManager userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            //_currentUser = currentUser;
            _permissionManager = permissionManager; 
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            var hr = await _roleManager.FindByNameAsync("HR");
            if(hr == null)
            {
                await _roleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "HR"));
            }
            hr = await _roleManager.FindByNameAsync("HR");
            await _permissionManager.SetForRoleAsync(hr.Name, Employee_Management_SystemPermissions.Employee.Create, true );
            await _permissionManager.SetForRoleAsync(hr.Name, Employee_Management_SystemPermissions.Employee.Edit, true);
            await _permissionManager.SetForRoleAsync(hr.Name, Employee_Management_SystemPermissions.Employee.Delete, true);
            await _permissionManager.SetForRoleAsync(hr.Name, Employee_Management_SystemPermissions.Employee.Read, true);
        }
    }
}

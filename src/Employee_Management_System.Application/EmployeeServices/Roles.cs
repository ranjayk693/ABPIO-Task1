using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace Employee_Management_System.EmployeeServices
{
    public class Roles : IdentityUser, ITransientDependency
    {
        //private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<IdentityUser> _userManager;

        //public Roles(
        //    RoleManager<IdentityRole> roleManager,
        //    UserManager<IdentityUser> userManager)
        //{
        //    _roleManager = roleManager;
        //    _userManager = userManager;
        //}

        //public async Task InitializeAsync()
        //{
        //    // Check if the "HR" role exists
        //    var adminRole=await _roleManager.FindByIdAsync("ADMIN");
        //    var hrRole = await _roleManager.FindByNameAsync("HR");
        //    var Employee = await _roleManager.FindByNameAsync("Employee");


        //    if (adminRole == null)
        //    {
        //        // Create the "HR" role
        //        await _roleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "ADMIN"));
        //    }

        //    if (hrRole == null)
        //    {
        //        // Create the "HR" role
        //        await _roleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "HR"));
        //    }

        //    if(Employee == null)
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole(Guid.NewGuid(), "Employee"));
        //    }
        //}
    }
}

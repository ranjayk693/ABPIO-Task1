using Employee_Management_System.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using static Volo.Abp.Identity.Settings.IdentitySettingNames;

namespace Employee_Management_System.EmployeeServices
{
    public class AssignHRService : ICreateHRService
    {
     
        private readonly IdentityUserManager _userManager;

        public AssignHRService(IdentityUserManager userManager)
        {
            _userManager = userManager;
        }


        /*Assign role*/
        [Authorize(Roles = "admin")]
        public async Task<HttpResponseMessage> AssignRole(string email)
        {
            if (email==null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Email cannot be empty.")
                };
            }

            var existingUser = await _userManager.FindByNameAsync(email);
            if (existingUser == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("User with this email does not exist.")
                };
            }

             await _userManager.AddToRoleAsync(existingUser, "hr");

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }


}

using Employee_Management_System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;

namespace Employee_Management_System.EmployeeServices
{
    public class CreateHRService:ICreateHRService
    {
        private readonly IdentityRoleAppService _roleAppService;

        public CreateHRService(IdentityRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }

        
    }
}

using Employee_Management_System.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Employee_Management_System.Interface
{
    public interface IEmployeeAppService:IApplicationService
    { 
        Task<List<EmployeeDto>> SearchEmployeesByName(string searchText);
    }
}

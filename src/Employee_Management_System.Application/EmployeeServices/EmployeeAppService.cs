using Employee_Management_System.Dtos;
using Employee_Management_System.Employees_Model;
using Employee_Management_System.Interface;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Employee_Management_System.EmployeeServices
{
    [Authorize(Roles="HR")]
    public class EmployeeAppService : CrudAppService<Employee, EmployeeDto, Guid, PagedAndSortedResultRequestDto, CreateEmployeeDto, CreateEmployeeDto>, IEmployeeAppService
    {
        public EmployeeAppService(IRepository<Employee, Guid> repository) : base(repository)
        {
        }

        public Task<List<EmployeeDto>> SearchEmployeesByName(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}

using Employee_Management_System.Dtos;
using Employee_Management_System.Employees_Model;
using Employee_Management_System.Interface;
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
    public class DepartementService : CrudAppService<Department, DepartementDto, Guid, PagedAndSortedResultRequestDto, CreateDepartementDto, CreateDepartementDto>, IDepartement
    {
        public DepartementService(IRepository<Department, Guid> repository) : base(repository)
        {
        }
    }
}

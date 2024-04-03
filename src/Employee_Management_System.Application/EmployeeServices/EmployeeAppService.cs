using AutoMapper;
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
    [Authorize(Roles = "admin,hr")]
    public class EmployeeAppService : CrudAppService<Employee, EmployeeDto, Guid, PagedAndSortedResultRequestDto, CreateEmployeeDto, CreateEmployeeDto>, IEmployeeAppService
    {
        private readonly IRepository<Employee> _repository;
        private readonly IMapper _mapper;
        public EmployeeAppService(IRepository<Employee, Guid> repository, IMapper mapper) : base(repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /*Search by Employee_id or Employee_name*/
        public async Task<EmployeeDto> SearchEmployeesByName(string name)
        {
            var employees = await _repository.FirstOrDefaultAsync(e => e.Name == name);
            if (employees == null)
            {
                throw new ArgumentException($"Employee with name '{name}' not found.");
            }
            return _mapper.Map<Employee, EmployeeDto>(employees);
        }


        /*Get the lsit of employee by departement id*/
        public async Task<List<EmployeeDto>> GetEmployeesByDepartment(Guid departmentId)
        {
            var employees = await _repository
                .GetListAsync(e => e.DepartmentId == departmentId);

            return _mapper.Map<List<Employee>, List<EmployeeDto>>(employees);
        }
    }
}

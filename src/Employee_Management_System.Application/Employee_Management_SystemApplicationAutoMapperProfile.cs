using AutoMapper;
using Employee_Management_System.Dtos;
using Employee_Management_System.Employees_Model;

namespace Employee_Management_System;

public class Employee_Management_SystemApplicationAutoMapperProfile : Profile
{
    public Employee_Management_SystemApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */


        CreateMap<CreateEmployeeDto, Employee>();
        CreateMap<Employee, EmployeeDto>();
        CreateMap<EmployeeDto, Employee>();

        /**/
        CreateMap<CreateDepartementDto, Department>();
        CreateMap<Department, DepartementDto>();
        CreateMap<DepartementDto, Department>();

    }
}

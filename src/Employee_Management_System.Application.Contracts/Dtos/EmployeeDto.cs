using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Employee_Management_System.Dtos
{
    public class EmployeeDto: EntityDto<Guid>
    {
     
        
        public string Name { get; set; }
        public int Age { get; set; }
        public Guid DepartmentId { get; set; }
        public decimal Salary { get; set; }
    }
}

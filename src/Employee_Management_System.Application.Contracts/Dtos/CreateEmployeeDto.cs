using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System.Dtos
{
    public class CreateEmployeeDto
    {
        public string Name { get; set; }
        public Guid DepartmentId { get; set; }
 
    }
}

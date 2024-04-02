using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Employee_Management_System.Employees_Model
{
    public class Employee : AuditedAggregateRoot<Guid>
    {
      
            public string Name { get; set; }
            //public int Age { get; set; }
            public Guid DepartmentId { get; set; }
            public Department Department { get; set; }
            //public decimal Salary { get; set; }
        

    }
}

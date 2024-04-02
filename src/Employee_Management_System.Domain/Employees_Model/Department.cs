using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Employee_Management_System.Employees_Model
{
    public class Department : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}

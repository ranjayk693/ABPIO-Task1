using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Employee_Management_System.Dtos
{
    public class DepartementDto: EntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

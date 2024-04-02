using System;
using System.Collections.Generic;
using System.Text;
using Employee_Management_System.Localization;
using Volo.Abp.Application.Services;

namespace Employee_Management_System;

/* Inherit your application services from this class.
 */
public abstract class Employee_Management_SystemAppService : ApplicationService
{
    protected Employee_Management_SystemAppService()
    {
        LocalizationResource = typeof(Employee_Management_SystemResource);
    }
}

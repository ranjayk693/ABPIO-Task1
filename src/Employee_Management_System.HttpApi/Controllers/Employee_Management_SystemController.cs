using Employee_Management_System.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Employee_Management_System.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Employee_Management_SystemController : AbpControllerBase
{
    protected Employee_Management_SystemController()
    {
        LocalizationResource = typeof(Employee_Management_SystemResource);
    }
}

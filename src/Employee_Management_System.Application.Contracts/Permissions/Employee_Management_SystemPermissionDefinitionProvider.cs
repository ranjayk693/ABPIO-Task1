using Employee_Management_System.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Employee_Management_System.Permissions;

public class Employee_Management_SystemPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Employee_Management_SystemPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Employee_Management_SystemPermissions.MyPermission1, L("Permission:MyPermission1"));

        var employee = context.AddGroup("Employee");
        var hr = employee.AddPermission("HR", L("Permission:HR"));
        var admin = employee.AddPermission("ADMIN", L("Permission:ADMIN"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Employee_Management_SystemResource>(name);
    }
}

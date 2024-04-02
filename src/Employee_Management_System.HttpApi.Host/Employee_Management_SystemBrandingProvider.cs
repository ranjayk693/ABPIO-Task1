using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Employee_Management_System;

[Dependency(ReplaceServices = true)]
public class Employee_Management_SystemBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Employee_Management_System";
}

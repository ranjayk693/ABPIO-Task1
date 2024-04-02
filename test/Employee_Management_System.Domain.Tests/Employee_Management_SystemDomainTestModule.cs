using Volo.Abp.Modularity;

namespace Employee_Management_System;

[DependsOn(
    typeof(Employee_Management_SystemDomainModule),
    typeof(Employee_Management_SystemTestBaseModule)
)]
public class Employee_Management_SystemDomainTestModule : AbpModule
{

}

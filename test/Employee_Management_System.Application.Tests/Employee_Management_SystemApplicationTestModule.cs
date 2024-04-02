using Volo.Abp.Modularity;

namespace Employee_Management_System;

[DependsOn(
    typeof(Employee_Management_SystemApplicationModule),
    typeof(Employee_Management_SystemDomainTestModule)
)]
public class Employee_Management_SystemApplicationTestModule : AbpModule
{

}

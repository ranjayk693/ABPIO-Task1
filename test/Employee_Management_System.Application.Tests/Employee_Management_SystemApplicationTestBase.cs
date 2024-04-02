using Volo.Abp.Modularity;

namespace Employee_Management_System;

public abstract class Employee_Management_SystemApplicationTestBase<TStartupModule> : Employee_Management_SystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

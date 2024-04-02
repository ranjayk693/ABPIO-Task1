using Volo.Abp.Modularity;

namespace Employee_Management_System;

/* Inherit from this class for your domain layer tests. */
public abstract class Employee_Management_SystemDomainTestBase<TStartupModule> : Employee_Management_SystemTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}

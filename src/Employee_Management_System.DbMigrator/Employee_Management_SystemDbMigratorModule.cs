using Employee_Management_System.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Employee_Management_System.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Employee_Management_SystemEntityFrameworkCoreModule),
    typeof(Employee_Management_SystemApplicationContractsModule)
    )]
public class Employee_Management_SystemDbMigratorModule : AbpModule
{
}

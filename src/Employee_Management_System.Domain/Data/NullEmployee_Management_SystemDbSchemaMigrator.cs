using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Employee_Management_System.Data;

/* This is used if database provider does't define
 * IEmployee_Management_SystemDbSchemaMigrator implementation.
 */
public class NullEmployee_Management_SystemDbSchemaMigrator : IEmployee_Management_SystemDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

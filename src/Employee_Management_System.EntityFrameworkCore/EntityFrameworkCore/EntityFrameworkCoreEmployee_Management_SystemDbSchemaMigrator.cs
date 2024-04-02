using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Employee_Management_System.Data;
using Volo.Abp.DependencyInjection;

namespace Employee_Management_System.EntityFrameworkCore;

public class EntityFrameworkCoreEmployee_Management_SystemDbSchemaMigrator
    : IEmployee_Management_SystemDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreEmployee_Management_SystemDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the Employee_Management_SystemDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Employee_Management_SystemDbContext>()
            .Database
            .MigrateAsync();
    }
}

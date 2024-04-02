using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Employee_Management_System.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Employee_Management_SystemDbContextFactory : IDesignTimeDbContextFactory<Employee_Management_SystemDbContext>
{
    public Employee_Management_SystemDbContext CreateDbContext(string[] args)
    {
        Employee_Management_SystemEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<Employee_Management_SystemDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new Employee_Management_SystemDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Employee_Management_System.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

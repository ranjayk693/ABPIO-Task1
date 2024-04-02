using System.Threading.Tasks;

namespace Employee_Management_System.Data;

public interface IEmployee_Management_SystemDbSchemaMigrator
{
    Task MigrateAsync();
}

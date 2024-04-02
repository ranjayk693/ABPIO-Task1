using Employee_Management_System.Samples;
using Xunit;

namespace Employee_Management_System.EntityFrameworkCore.Domains;

[Collection(Employee_Management_SystemTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Employee_Management_SystemEntityFrameworkCoreTestModule>
{

}

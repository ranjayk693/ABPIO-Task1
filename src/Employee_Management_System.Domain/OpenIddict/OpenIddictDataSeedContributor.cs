using System;
using System.Threading.Tasks;
//using Volo.Abp.Identity.IdentityDataSeedContributors;
using Volo.Abp.Data;
//using Volo.Abp.Identity;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Identity;

namespace Employee_Management_System.OpenIddict;

public class IdentityDataSeedContributor : IIdentityDataSeeder, ITransientDependency
{
    public Task<IdentityDataSeedResult> SeedAsync(string adminEmail, string adminPassword, Guid? tenantId = null)
    {
        throw new NotImplementedException();
    }
}

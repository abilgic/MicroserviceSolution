using MicroserviceSolution.AdministrationService;
using MicroserviceSolution.AdministrationService.EntityFrameworkCore;
using MicroserviceSolution.IdentityService;
using MicroserviceSolution.IdentityService.EntityFrameworkCore;
using MicroserviceSolution.ProductService;
using MicroserviceSolution.ProductService.EntityFrameworkCore;
using MicroserviceSolution.SaasService;
using MicroserviceSolution.SaasService.EntityFrameworkCore;
using MicroserviceSolution.Shared.Hosting;
using Volo.Abp.Modularity;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;

namespace MicroserviceSolution.DbMigrator;

[DependsOn(
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(MicroserviceSolutionSharedHostingModule),
    typeof(IdentityServiceEntityFrameworkCoreModule),
    typeof(IdentityServiceApplicationContractsModule),
    typeof(SaasServiceEntityFrameworkCoreModule),
    typeof(SaasServiceApplicationContractsModule),
    typeof(AdministrationServiceEntityFrameworkCoreModule),
    typeof(AdministrationServiceApplicationContractsModule),
    typeof(ProductServiceApplicationContractsModule),
    typeof(ProductServiceEntityFrameworkCoreModule)
)]
public class MicroserviceSolutionDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "MicroserviceSolution:"; });
    }
}

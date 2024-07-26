using Volo.Abp.Modularity;

namespace MicroserviceSolution.IdentityService;

[DependsOn(
    typeof(IdentityServiceApplicationModule),
    typeof(IdentityServiceDomainTestModule)
    )]
public class IdentityServiceApplicationTestModule : AbpModule
{

}

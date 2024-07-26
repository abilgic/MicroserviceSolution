using MicroserviceSolution.SaasService.Application;
using Volo.Abp.Modularity;

namespace MicroserviceSolution.SaasService;

[DependsOn(
    typeof(SaasServiceApplicationModule),
    typeof(SaasServiceDomainTestModule)
    )]
public class SaasServiceApplicationTestModule : AbpModule
{

}

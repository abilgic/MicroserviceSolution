using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MicroserviceSolution.AuthServer;

[Dependency(ReplaceServices = true)]
public class MicroserviceSolutionBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MicroserviceSolution";
}

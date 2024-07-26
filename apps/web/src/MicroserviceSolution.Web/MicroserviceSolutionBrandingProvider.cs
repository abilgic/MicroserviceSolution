using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MicroserviceSolution.Web;

[Dependency(ReplaceServices = true)]
public class MicroserviceSolutionBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MicroserviceSolution";
}

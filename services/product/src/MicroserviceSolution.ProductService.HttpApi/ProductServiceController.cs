using MicroserviceSolution.ProductService.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MicroserviceSolution.ProductService;

public abstract class ProductServiceController : AbpController
{
    protected ProductServiceController()
    {
        LocalizationResource = typeof(ProductServiceResource);
    }
}

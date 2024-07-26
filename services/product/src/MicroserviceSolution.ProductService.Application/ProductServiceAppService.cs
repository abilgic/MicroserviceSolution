﻿using MicroserviceSolution.ProductService.Localization;
using Volo.Abp.Application.Services;

namespace MicroserviceSolution.ProductService;

public abstract class ProductServiceAppService : ApplicationService
{
    protected ProductServiceAppService()
    {
        LocalizationResource = typeof(ProductServiceResource);
        ObjectMapperContext = typeof(ProductServiceApplicationModule);
    }
}

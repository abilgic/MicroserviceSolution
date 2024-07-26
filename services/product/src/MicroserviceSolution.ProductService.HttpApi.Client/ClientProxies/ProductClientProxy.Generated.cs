// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using MicroserviceSolution.ProductService.Products;

// ReSharper disable once CheckNamespace
namespace MicroserviceSolution.ProductService.Products.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IProductAppService), typeof(ProductClientProxy))]
public partial class ProductClientProxy : ClientProxyBase<IProductAppService>, IProductAppService
{
    public virtual async Task<PagedResultDto<ProductDto>> GetListAsync(GetProductsInput input)
    {
        return await RequestAsync<PagedResultDto<ProductDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(GetProductsInput), input }
        });
    }

    public virtual async Task<ProductDto> GetAsync(Guid id)
    {
        return await RequestAsync<ProductDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<ProductDto> CreateAsync(ProductCreateDto input)
    {
        return await RequestAsync<ProductDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(ProductCreateDto), input }
        });
    }

    public virtual async Task<ProductDto> UpdateAsync(Guid id, ProductUpdateDto input)
    {
        return await RequestAsync<ProductDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(ProductUpdateDto), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }
}

using AutoMapper;
using MicroserviceSolution.ProductService.Products;

namespace MicroserviceSolution.ProductService;

public class ProductServiceApplicationAutoMapperProfile : Profile
{
    public ProductServiceApplicationAutoMapperProfile()
    {
        CreateMap<Product, ProductDto>().MapExtraProperties();
    }
}

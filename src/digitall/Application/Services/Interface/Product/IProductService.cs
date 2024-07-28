using Domain.DTOs.Product;
using Domain.DTOs.Vpn;
using Domain.Enums.Product;
using Domain.Enums.Vpn;

namespace Application.Services.Interface.Product;

public interface IProductService
{
    public Task<AddProductResult> AddProductAsync(AddProductDto product, long userId);
    public Task<AddVpnProductResult> AddVpnProductAsync(AddVpnProductDto product, long userId);
    public Task<List<ProductDto>> GetProductAsync();
    public Task<List<ProductDto>> GetProductByCategoryIdAsync(long categoryId);
    public Task<ProductDto> GetProductByIdAsync(long productId);
    public Task<FilterProductDto> FilterProductAsync(FilterProductDto filter, long userId);
}
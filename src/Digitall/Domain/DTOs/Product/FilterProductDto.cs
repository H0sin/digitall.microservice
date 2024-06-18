using Domain.DTOs.Paging;

namespace Domain.DTOs.Product;

public class FilterProductDto : BasePaging<ProductDto>
{
    public long CategoryId { get; set; }

    public string? ProductName { get; set; }
}
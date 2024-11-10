using Domain.Common;

namespace Domain.Entities.Apple;

public class AppleIdType : BaseEntity
{
    public long ProductId { get; set; }
    public Product.Product? Product { get; set; }
    public string? Title { get; set; }
    public long Price { get; set; }
    public ICollection<AppleId>? AppleIds { get; set; }
}